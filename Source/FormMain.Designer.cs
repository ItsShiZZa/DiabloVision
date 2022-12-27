namespace DiabloVision
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.CamXLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProcessScanTimer = new System.Windows.Forms.Timer(this.components);
            this.PitchSlider = new System.Windows.Forms.TrackBar();
            this.ResetPitchButton = new System.Windows.Forms.Button();
            this.PitchValueLabel = new System.Windows.Forms.Label();
            this.YawValueLabel = new System.Windows.Forms.Label();
            this.ResetYawButton = new System.Windows.Forms.Button();
            this.YawSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.RollValueLabel = new System.Windows.Forms.Label();
            this.ResetRollButton = new System.Windows.Forms.Button();
            this.RollSlider = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ZoomValueLabel = new System.Windows.Forms.Label();
            this.ResetZoomButton = new System.Windows.Forms.Button();
            this.ZoomSlider = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.ValueScanTimer = new System.Windows.Forms.Timer(this.components);
            this.ZoomScanTimer = new System.Windows.Forms.Timer(this.components);
            this.ExtendedSearchCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchZoomCheckbox = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PitchSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YawSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // CamXLabel
            // 
            this.CamXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamXLabel.Location = new System.Drawing.Point(12, 22);
            this.CamXLabel.Name = "CamXLabel";
            this.CamXLabel.Size = new System.Drawing.Size(82, 13);
            this.CamXLabel.TabIndex = 0;
            this.CamXLabel.Text = "Pitch";
            this.CamXLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 255);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel1.Text = "Scanning for D2R process...";
            // 
            // ProcessScanTimer
            // 
            this.ProcessScanTimer.Enabled = true;
            this.ProcessScanTimer.Interval = 3000;
            this.ProcessScanTimer.Tick += new System.EventHandler(this.ProcessScanTimer_Tick);
            // 
            // PitchSlider
            // 
            this.PitchSlider.BackColor = System.Drawing.SystemColors.Control;
            this.PitchSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.PitchSlider.Enabled = false;
            this.PitchSlider.Location = new System.Drawing.Point(87, 21);
            this.PitchSlider.Maximum = 100;
            this.PitchSlider.Name = "PitchSlider";
            this.PitchSlider.Size = new System.Drawing.Size(490, 45);
            this.PitchSlider.TabIndex = 3;
            this.PitchSlider.TickFrequency = 5;
            this.PitchSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.PitchSlider.Value = 50;
            this.PitchSlider.ValueChanged += new System.EventHandler(this.PitchSlider_ValueChanged);
            // 
            // ResetPitchButton
            // 
            this.ResetPitchButton.Location = new System.Drawing.Point(583, 21);
            this.ResetPitchButton.Name = "ResetPitchButton";
            this.ResetPitchButton.Size = new System.Drawing.Size(52, 26);
            this.ResetPitchButton.TabIndex = 4;
            this.ResetPitchButton.Text = "Reset";
            this.ResetPitchButton.UseVisualStyleBackColor = true;
            this.ResetPitchButton.Click += new System.EventHandler(this.ResetPitchButton_Click);
            // 
            // PitchValueLabel
            // 
            this.PitchValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PitchValueLabel.Location = new System.Drawing.Point(12, 40);
            this.PitchValueLabel.Name = "PitchValueLabel";
            this.PitchValueLabel.Size = new System.Drawing.Size(82, 13);
            this.PitchValueLabel.TabIndex = 5;
            this.PitchValueLabel.Text = "-0.892";
            this.PitchValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YawValueLabel
            // 
            this.YawValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YawValueLabel.Location = new System.Drawing.Point(12, 92);
            this.YawValueLabel.Name = "YawValueLabel";
            this.YawValueLabel.Size = new System.Drawing.Size(82, 13);
            this.YawValueLabel.TabIndex = 9;
            this.YawValueLabel.Text = "0.239";
            this.YawValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetYawButton
            // 
            this.ResetYawButton.Location = new System.Drawing.Point(583, 72);
            this.ResetYawButton.Name = "ResetYawButton";
            this.ResetYawButton.Size = new System.Drawing.Size(52, 26);
            this.ResetYawButton.TabIndex = 8;
            this.ResetYawButton.Text = "Reset";
            this.ResetYawButton.UseVisualStyleBackColor = true;
            this.ResetYawButton.Click += new System.EventHandler(this.ResetYawButton_Click);
            // 
            // YawSlider
            // 
            this.YawSlider.BackColor = System.Drawing.SystemColors.Control;
            this.YawSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.YawSlider.Enabled = false;
            this.YawSlider.Location = new System.Drawing.Point(87, 72);
            this.YawSlider.Maximum = 100;
            this.YawSlider.Name = "YawSlider";
            this.YawSlider.Size = new System.Drawing.Size(490, 45);
            this.YawSlider.TabIndex = 7;
            this.YawSlider.TickFrequency = 5;
            this.YawSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.YawSlider.Value = 50;
            this.YawSlider.ValueChanged += new System.EventHandler(this.YawSlider_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yaw";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RollValueLabel
            // 
            this.RollValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollValueLabel.Location = new System.Drawing.Point(12, 143);
            this.RollValueLabel.Name = "RollValueLabel";
            this.RollValueLabel.Size = new System.Drawing.Size(82, 13);
            this.RollValueLabel.TabIndex = 13;
            this.RollValueLabel.Text = "0.370";
            this.RollValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RollValueLabel.Click += new System.EventHandler(this.RollValueLabel_Click);
            // 
            // ResetRollButton
            // 
            this.ResetRollButton.Location = new System.Drawing.Point(583, 123);
            this.ResetRollButton.Name = "ResetRollButton";
            this.ResetRollButton.Size = new System.Drawing.Size(52, 26);
            this.ResetRollButton.TabIndex = 12;
            this.ResetRollButton.Text = "Reset";
            this.ResetRollButton.UseVisualStyleBackColor = true;
            this.ResetRollButton.Click += new System.EventHandler(this.ResetRollButton_Click);
            // 
            // RollSlider
            // 
            this.RollSlider.BackColor = System.Drawing.SystemColors.Control;
            this.RollSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.RollSlider.Enabled = false;
            this.RollSlider.Location = new System.Drawing.Point(87, 123);
            this.RollSlider.Maximum = 100;
            this.RollSlider.Name = "RollSlider";
            this.RollSlider.Size = new System.Drawing.Size(490, 45);
            this.RollSlider.TabIndex = 11;
            this.RollSlider.TickFrequency = 5;
            this.RollSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.RollSlider.Value = 50;
            this.RollSlider.ValueChanged += new System.EventHandler(this.RollSlider_ValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Roll";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ZoomValueLabel
            // 
            this.ZoomValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomValueLabel.Location = new System.Drawing.Point(12, 194);
            this.ZoomValueLabel.Name = "ZoomValueLabel";
            this.ZoomValueLabel.Size = new System.Drawing.Size(82, 13);
            this.ZoomValueLabel.TabIndex = 17;
            this.ZoomValueLabel.Text = "0.000";
            this.ZoomValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ZoomValueLabel.Click += new System.EventHandler(this.ZoomValueLabel_Click);
            // 
            // ResetZoomButton
            // 
            this.ResetZoomButton.Location = new System.Drawing.Point(583, 174);
            this.ResetZoomButton.Name = "ResetZoomButton";
            this.ResetZoomButton.Size = new System.Drawing.Size(52, 26);
            this.ResetZoomButton.TabIndex = 16;
            this.ResetZoomButton.Text = "Reset";
            this.ResetZoomButton.UseVisualStyleBackColor = true;
            this.ResetZoomButton.Click += new System.EventHandler(this.ResetZoomButton_Click);
            // 
            // ZoomSlider
            // 
            this.ZoomSlider.BackColor = System.Drawing.SystemColors.Control;
            this.ZoomSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.ZoomSlider.Enabled = false;
            this.ZoomSlider.LargeChange = 50;
            this.ZoomSlider.Location = new System.Drawing.Point(87, 174);
            this.ZoomSlider.Maximum = 400;
            this.ZoomSlider.Name = "ZoomSlider";
            this.ZoomSlider.Size = new System.Drawing.Size(490, 45);
            this.ZoomSlider.TabIndex = 15;
            this.ZoomSlider.TickFrequency = 10;
            this.ZoomSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ZoomSlider.Value = 50;
            this.ZoomSlider.Scroll += new System.EventHandler(this.ZoomSlider_Scroll);
            this.ZoomSlider.ValueChanged += new System.EventHandler(this.ZoomSlider_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Zoom";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ValueScanTimer
            // 
            this.ValueScanTimer.Interval = 20000;
            this.ValueScanTimer.Tick += new System.EventHandler(this.ValueScanTimer_Tick);
            // 
            // ZoomScanTimer
            // 
            this.ZoomScanTimer.Interval = 30000;
            this.ZoomScanTimer.Tick += new System.EventHandler(this.ZoomScanTimer_Tick);
            // 
            // ExtendedSearchCheckbox
            // 
            this.ExtendedSearchCheckbox.AutoSize = true;
            this.ExtendedSearchCheckbox.Location = new System.Drawing.Point(229, 221);
            this.ExtendedSearchCheckbox.Name = "ExtendedSearchCheckbox";
            this.ExtendedSearchCheckbox.Size = new System.Drawing.Size(164, 17);
            this.ExtendedSearchCheckbox.TabIndex = 18;
            this.ExtendedSearchCheckbox.Text = "Use extended search regions";
            this.ExtendedSearchCheckbox.UseVisualStyleBackColor = true;
            // 
            // SearchZoomCheckbox
            // 
            this.SearchZoomCheckbox.AutoSize = true;
            this.SearchZoomCheckbox.Checked = true;
            this.SearchZoomCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchZoomCheckbox.Location = new System.Drawing.Point(36, 221);
            this.SearchZoomCheckbox.Name = "SearchZoomCheckbox";
            this.SearchZoomCheckbox.Size = new System.Drawing.Size(158, 17);
            this.SearchZoomCheckbox.TabIndex = 19;
            this.SearchZoomCheckbox.Text = "Zoom value search enabled";
            this.SearchZoomCheckbox.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 277);
            this.Controls.Add(this.SearchZoomCheckbox);
            this.Controls.Add(this.ExtendedSearchCheckbox);
            this.Controls.Add(this.ZoomValueLabel);
            this.Controls.Add(this.ResetZoomButton);
            this.Controls.Add(this.ZoomSlider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RollValueLabel);
            this.Controls.Add(this.ResetRollButton);
            this.Controls.Add(this.RollSlider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YawValueLabel);
            this.Controls.Add(this.ResetYawButton);
            this.Controls.Add(this.YawSlider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PitchValueLabel);
            this.Controls.Add(this.ResetPitchButton);
            this.Controls.Add(this.PitchSlider);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CamXLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiabloVision v2 - created by shiZZa - New Version Coming Soon";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PitchSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YawSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CamXLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Timer ProcessScanTimer;
        public System.Windows.Forms.TrackBar PitchSlider;
        public System.Windows.Forms.Button ResetPitchButton;
        public System.Windows.Forms.Button ResetYawButton;
        public System.Windows.Forms.TrackBar YawSlider;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button ResetRollButton;
        public System.Windows.Forms.TrackBar RollSlider;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button ResetZoomButton;
        public System.Windows.Forms.TrackBar ZoomSlider;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Timer ValueScanTimer;
        public System.Windows.Forms.Timer ZoomScanTimer;
        public System.Windows.Forms.Label PitchValueLabel;
        public System.Windows.Forms.Label YawValueLabel;
        public System.Windows.Forms.Label RollValueLabel;
        public System.Windows.Forms.Label ZoomValueLabel;
        public System.Windows.Forms.CheckBox ExtendedSearchCheckbox;
        public System.Windows.Forms.CheckBox SearchZoomCheckbox;
    }
}

