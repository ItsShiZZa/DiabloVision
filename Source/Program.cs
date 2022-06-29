using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Memory;

namespace DiabloVision
{
    internal static class Program
    {
        public const string D2R_PROCESS_NAME = "D2R";
        public static FormMain AppActiveForm;
        public static Mem MemLib;
        public static Process GameProcess;
        public static int GamePid = 0;
        public static bool ValuesActive = false;
        public static bool ZoomValueActive = false;

        private static bool CurrentlyScanning = false;

        private static long ScanBase = 0;
        private static long YawBase = 0;
        private static long RollBase = 0;
        private static long ZoomBase = 0;

        private const string DefaultPitchBytes = "0x44 0x74 0x64 0xBF";
        private const string DefaultYawBytes = "0x3F 0xDB 0x74 0x3E";
        private const string DefaultRollBytes = "0xF4 0x41 0xBD 0x3E";
        private const string DefaultZoomBytes = "0x00 0x00 0x00 0x00";

        public static float DefaultPitch = -0.8923990726f;
        public static float DefaultYaw = 0.2391176075f;
        public static float DefaultRoll = 0.3696438074f;
        public static float DefaultZoom = 0f;

        private static float CameraPitch = -0.8923990726f;
        private static float CameraYaw = 0.2391176075f;
        private static float CameraRoll = 0.3696438074f;
        private static float CameraZoom = 0f;

        private static string PitchBaseString = "0x0";
        private static string YawBaseString = "0x0";
        private static string RollBaseString = "0x0";
        private static string ZoomBaseString = "0x0";

        public static void Init()
        {
            MemLib = new Mem();
            if (MemLib == null)
            {
                MessageBox.Show("Could not create instance of memory.dll", "Error", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }

        }
        public static bool D2RIsAttached()
        {
            if (MemLib == null)
                return false;
            if (GameProcess == null)
                return false;
            if (!(GamePid > 0))
                return false;
            return true;
        }

        public async static void D2RScanValues()
        {
            if (D2RIsAttached())
            {
                CurrentlyScanning = true;
                AppActiveForm.toolStripStatusLabel1.Text = "Attached to process ... Scanning for values ....";
                var scan = await MemLib.AoBScan(0, 0x7FFFFFFFFFFF, "44 74 64 BF 3F DB 74 3E F4 41 BD 3E", AppActiveForm.ExtendedSearchCheckbox.Checked, true, AppActiveForm.ExtendedSearchCheckbox.Checked);
                long result = scan.FirstOrDefault();
                if (result != 0)
                {
                    CurrentlyScanning = false;
                    AppActiveForm.ValueScanTimer.Enabled = false;
                    ScanBase = result;
                    PitchBaseString = "0x" + ScanBase.ToString("X");
                    YawBase = ScanBase + 4;
                    YawBaseString = "0x" + YawBase.ToString("X");
                    RollBase = ScanBase + 8;
                    RollBaseString = "0x" + RollBase.ToString("X");
                    ActivateValues();
                }                
            }            
        }

        public async static void D2RScanZoomValue()
        {
            if (ValuesActive && D2RIsAttached())
            {
                CurrentlyScanning = true;
                var scan = await MemLib.AoBScan(0, 0x7FFFFFFFFFFF, "00 00 30 04 ?? ?? ?? 7F 00 00 06 00 00 00", false, true, false);
                long result = scan.FirstOrDefault();
                if (result != 0)
                {
                    CurrentlyScanning = false;
                    AppActiveForm.ZoomScanTimer.Enabled = false;
                    ZoomValueActive = true;                    
                    ZoomBase = result + 0x3A;
                    ZoomBaseString = "0x" + ZoomBase.ToString("X");
                    AppActiveForm.ZoomSlider.Enabled = true;
                    Beep();
                }
            }
        }

        public static void ActivateValues()
        {
            ValuesActive = true;
            AppActiveForm.toolStripStatusLabel1.Text = "Attached to process ... Values found";
            if (AppActiveForm.SearchZoomCheckbox.Checked)
            {
                D2RScanZoomValue();
            }
            AppActiveForm.PitchSlider.Enabled = true;
            AppActiveForm.YawSlider.Enabled = true;
            AppActiveForm.RollSlider.Enabled = true;
            AppActiveForm.ZoomScanTimer.Enabled = true;
            Beep();
        }

        public static void Beep()
        {
            System.Media.SystemSounds.Beep.Play();
        }

        public static void DeactivateValues()
        {
            ValuesActive = false;
            ZoomValueActive = false;
            GameProcess = null;
            GamePid = 0;
            AppActiveForm.PitchSlider.Enabled = false;
            AppActiveForm.YawSlider.Enabled = false;
            AppActiveForm.RollSlider.Enabled = false;
            AppActiveForm.ZoomSlider.Enabled = false;
            AppActiveForm.ProcessScanTimer.Enabled = true;
        }

        public static void D2RCheckForProcess()
        {        
            if (!MemLib.OpenProcess(D2R_PROCESS_NAME))
            {
                AppActiveForm.toolStripStatusLabel1.Text = "Scanning for D2R process ...";
                GameProcess = null;
                GamePid = 0;
                DeactivateValues();
                AppActiveForm.ValueScanTimer.Enabled = false;

            } else
            {
                AppActiveForm.toolStripStatusLabel1.Text = "Attached to process";
                GameProcess = MemLib.mProc.Process;
                GamePid = MemLib.mProc.Process.Id;
                AppActiveForm.ProcessScanTimer.Enabled = false;
                AppActiveForm.ValueScanTimer.Enabled = true;
                D2RScanValues();
            }
        }

        public static void UIPitchChanged(int value)
        {
            if (ValuesActive)
            {
                float newvalue = value * -0.017847981452f;
                if (!MemLib.WriteMemory(PitchBaseString, "float", newvalue.ToString()))
                {
                    DeactivateValues();
                }
                else
                {
                    CameraPitch = newvalue;
                    AppActiveForm.PitchValueLabel.Text = newvalue.ToString("0.000");
                }
            }
        }

        public static void UIYawChanged(int value)
        {
            if (ValuesActive)
            {
                float newvalue = (value * 0.03521764786f) - 1.521764786f;
                if (!MemLib.WriteMemory(YawBaseString, "float", newvalue.ToString()))
                {
                    DeactivateValues();
                }
                else
                {
                    CameraYaw = newvalue;
                    AppActiveForm.YawValueLabel.Text = newvalue.ToString("0.000");
                }
            }
        }

        public static void UIRollChanged(int value)
        {
            if (ValuesActive)
            {
                float newvalue = (value * 0.032607123852f) - 1.2607123852f;
                if (!MemLib.WriteMemory(RollBaseString, "float", newvalue.ToString()))
                {
                    DeactivateValues();
                } else
                {
                    CameraRoll = newvalue;
                    AppActiveForm.RollValueLabel.Text = newvalue.ToString("0.000");
                }                
            }
        }

        public static void UIZoomChanged(int value)
        {
            if (ValuesActive && ZoomValueActive)
            {
                float newvalue = (value * 0.005f) - 0.25f;
                if (!MemLib.WriteMemory(ZoomBaseString, "float", newvalue.ToString()))
                {
                    DeactivateValues();
                }
                else
                {
                    CameraZoom = newvalue;
                    AppActiveForm.ZoomValueLabel.Text = newvalue.ToString("0.000");
                }
            }
        }

        public static void UIRefreshValues()
        {
            AppActiveForm.PitchValueLabel.Text = CameraPitch.ToString("0.000");
            AppActiveForm.YawValueLabel.Text = CameraYaw.ToString("0.000");
            AppActiveForm.RollValueLabel.Text = CameraRoll.ToString("0.000");
            if (ZoomValueActive)
            {
                AppActiveForm.ZoomValueLabel.Text = CameraZoom.ToString("0.000");
            }
        }

        public static void UIResetPitch()
        {
            if (ValuesActive)
            {
                AppActiveForm.PitchSlider.Value = 50;
                if (!ValuesActive || !MemLib.WriteMemory(PitchBaseString, "bytes", DefaultPitchBytes))
                {
                    DeactivateValues();
                }
                else
                {
                    CameraPitch = DefaultPitch;
                    UIRefreshValues();
                }
            }
        }

        public static void UIResetYaw()
        {
            if (ValuesActive)
            {
                AppActiveForm.YawSlider.Value = 50;
                if (!ValuesActive || !MemLib.WriteMemory(YawBaseString, "bytes", DefaultYawBytes))
                {
                    DeactivateValues();
                }
                else
                {
                    CameraYaw = DefaultYaw;
                    UIRefreshValues();
                }
            }
        }

        public static void UIResetRoll()
        {
            if (ValuesActive)
            {
                AppActiveForm.RollSlider.Value = 50;
                if (!ValuesActive || !MemLib.WriteMemory(RollBaseString, "bytes", DefaultRollBytes))
                {
                    DeactivateValues();
                }
                else
                {
                    CameraRoll = DefaultRoll;
                    UIRefreshValues();
                }
            }
        }

        public static void UIResetZoom()
        {
            if (ValuesActive && ZoomValueActive)
            {
                AppActiveForm.ZoomSlider.Value = 50;
                if (!ValuesActive || !ZoomValueActive || !MemLib.WriteMemory(ZoomBaseString, "bytes", DefaultZoomBytes))
                {
                    DeactivateValues();
                }
                else
                {
                    CameraZoom = DefaultZoom;
                    UIRefreshValues();
                }
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppActiveForm = new FormMain();
            Application.Run(AppActiveForm);
        }
    }
}
