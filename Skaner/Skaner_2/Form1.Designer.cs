namespace Skaner_2
{
    partial class Form1
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
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.scanPictureBox = new System.Windows.Forms.PictureBox();
            this.ResolutionTrackBar = new System.Windows.Forms.TrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.resolution = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.contrast = new System.Windows.Forms.Label();
            this.brightness = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(18, 29);
            this.comboBoxDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(195, 21);
            this.comboBoxDevice.TabIndex = 0;
            this.comboBoxDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevice_SelectedIndexChanged);
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(19, 304);
            this.scanButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(102, 51);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // scanPictureBox
            // 
            this.scanPictureBox.Location = new System.Drawing.Point(487, 17);
            this.scanPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scanPictureBox.Name = "scanPictureBox";
            this.scanPictureBox.Size = new System.Drawing.Size(250, 332);
            this.scanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scanPictureBox.TabIndex = 2;
            this.scanPictureBox.TabStop = false;
            this.scanPictureBox.Click += new System.EventHandler(this.scanPictureBox_Click);
            // 
            // ResolutionTrackBar
            // 
            this.ResolutionTrackBar.Location = new System.Drawing.Point(18, 86);
            this.ResolutionTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResolutionTrackBar.Name = "ResolutionTrackBar";
            this.ResolutionTrackBar.Size = new System.Drawing.Size(193, 45);
            this.ResolutionTrackBar.SmallChange = 150;
            this.ResolutionTrackBar.TabIndex = 150;
            this.ResolutionTrackBar.TabStop = false;
            this.ResolutionTrackBar.TickFrequency = 150;
            this.ResolutionTrackBar.Scroll += new System.EventHandler(this.ResolutionTrackBar_Scroll);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(165, 304);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 51);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resolution
            // 
            this.resolution.AutoSize = true;
            this.resolution.Location = new System.Drawing.Point(251, 86);
            this.resolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(35, 13);
            this.resolution.TabIndex = 5;
            this.resolution.Text = "label1";
            this.resolution.Click += new System.EventHandler(this.resolution_Click);
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(30, 118);
            this.contrastLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(46, 13);
            this.contrastLabel.TabIndex = 6;
            this.contrastLabel.Text = "Contrast";
            this.contrastLabel.Click += new System.EventHandler(this.contrastLabel_Click);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(30, 63);
            this.resolutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.resolutionLabel.TabIndex = 7;
            this.resolutionLabel.Text = "Resolution";
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(19, 135);
            this.contrastTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(193, 45);
            this.contrastTrackBar.TabIndex = 8;
            this.contrastTrackBar.TickFrequency = 5;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(30, 166);
            this.brightnessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.brightnessLabel.TabIndex = 9;
            this.brightnessLabel.Text = "Brightness";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(18, 190);
            this.brightnessTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(193, 45);
            this.brightnessTrackBar.TabIndex = 100;
            this.brightnessTrackBar.TickFrequency = 5;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // contrast
            // 
            this.contrast.AutoSize = true;
            this.contrast.Location = new System.Drawing.Point(251, 135);
            this.contrast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contrast.Name = "contrast";
            this.contrast.Size = new System.Drawing.Size(35, 13);
            this.contrast.TabIndex = 11;
            this.contrast.Text = "label5";
            this.contrast.Click += new System.EventHandler(this.contrast_Click);
            // 
            // brightness
            // 
            this.brightness.AutoSize = true;
            this.brightness.Location = new System.Drawing.Point(251, 190);
            this.brightness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(35, 13);
            this.brightness.TabIndex = 12;
            this.brightness.Text = "label6";
            this.brightness.Click += new System.EventHandler(this.brightness_Click);
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Location = new System.Drawing.Point(18, 248);
            this.colorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(195, 21);
            this.colorBox.TabIndex = 101;
            this.colorBox.SelectedIndexChanged += new System.EventHandler(this.colorBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Color mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.brightness);
            this.Controls.Add(this.contrast);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ResolutionTrackBar);
            this.Controls.Add(this.scanPictureBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.comboBoxDevice);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.PictureBox scanPictureBox;
        private System.Windows.Forms.TrackBar ResolutionTrackBar;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label resolution;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.Label contrast;
        private System.Windows.Forms.Label brightness;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Label label2;
    }
}

