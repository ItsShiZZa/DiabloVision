using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Memory;

namespace DiabloVision
{
    public partial class FormMain : Form
    {


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Program.Init();
            MessageBox.Show("Happy Holidays and Happy New Year to you all, especially my supporters who showed me that people actually do care about my work. Thanks to your generous words of kindness I have decided to make another, better version of Diablo Vision. If you have any better name ideas or suggestions for features please e-mail me at lllegrayfox@gmail.com. In the meantime, here is the working Diablo Vision I've been waiting you wait far too long for. Cheat Engine tables are fixed now as well (the .CT file included in the release). You can also reach me via Steam messenger by adding me from profiles/76561198864195792. Enjoy.", "Merry Christmas and Happy New Year", MessageBoxButtons.OK);
            MessageBox.Show("This tool is intended for single player use only. Use of this tool is possibly a violation of the terms of service of Blizzard. Use of this tool in multiplayer definitely IS a violation of the terms of service. It is recommended you block D2R.exe in Windows Firewall any time you use this tool so that no connection to battle.net would be possible. Do not use this tool on battle.net or you will certainly be banned. If you change some values from default and close DiabloVision, you may need to completely reload D2R to reset the values before it can find them again. Good luck have fun!", "Warning", MessageBoxButtons.OK);
        }

        private void ProcessScanTimer_Tick(object sender, EventArgs e)
        {
            Program.D2RCheckForProcess();
        }

        private void ValueScanTimer_Tick(object sender, EventArgs e)
        {
            Program.D2RScanValues();
        }

        private void PitchSlider_ValueChanged(object sender, EventArgs e)
        {
            Program.UIPitchChanged(PitchSlider.Value);
        }

        private void YawSlider_ValueChanged(object sender, EventArgs e)
        {
            Program.UIYawChanged(YawSlider.Value);
        }

        private void RollSlider_ValueChanged(object sender, EventArgs e)
        {
            Program.UIRollChanged(RollSlider.Value);
        }

        private void ResetPitchButton_Click(object sender, EventArgs e)
        {
            Program.UIResetPitch();
        }

        private void ResetYawButton_Click(object sender, EventArgs e)
        {
            Program.UIResetYaw();
        }

        private void ResetRollButton_Click(object sender, EventArgs e)
        {
            Program.UIResetRoll();
        }

        private void ZoomScanTimer_Tick(object sender, EventArgs e)
        {
            if (SearchZoomCheckbox.Checked)
            {
                Program.D2RScanZoomValue();
            }                
        }

        private void ZoomSlider_ValueChanged(object sender, EventArgs e)
        {
            Program.UIZoomChanged(ZoomSlider.Value);
        }

        private void ResetZoomButton_Click(object sender, EventArgs e)
        {
            Program.UIResetZoom();
        }

        private void ZoomValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void RollValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void ZoomSlider_Scroll(object sender, EventArgs e)
        {

        }
    }
}
