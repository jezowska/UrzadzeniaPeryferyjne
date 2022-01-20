namespace KartaMuzyczna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFile = new System.Windows.Forms.Button();
            this.playMusic = new System.Windows.Forms.Button();
            this.playLabel = new System.Windows.Forms.Label();
            this.libraryBox = new System.Windows.Forms.ComboBox();
            this.pause = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chooseFile.Location = new System.Drawing.Point(21, 78);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(99, 48);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "Choose file (*.wav; *.mp3)";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // playMusic
            // 
            this.playMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playMusic.Location = new System.Drawing.Point(21, 132);
            this.playMusic.Name = "playMusic";
            this.playMusic.Size = new System.Drawing.Size(99, 48);
            this.playMusic.TabIndex = 1;
            this.playMusic.Text = "Play";
            this.playMusic.UseVisualStyleBackColor = true;
            this.playMusic.Click += new System.EventHandler(this.playMusic_Click);
            // 
            // playLabel
            // 
            this.playLabel.AutoSize = true;
            this.playLabel.Location = new System.Drawing.Point(25, 19);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(74, 15);
            this.playLabel.TabIndex = 7;
            this.playLabel.Text = "Play method";
            // 
            // libraryBox
            // 
            this.libraryBox.FormattingEnabled = true;
            this.libraryBox.Location = new System.Drawing.Point(107, 15);
            this.libraryBox.Name = "libraryBox";
            this.libraryBox.Size = new System.Drawing.Size(121, 23);
            this.libraryBox.TabIndex = 8;
            this.libraryBox.SelectedIndexChanged += new System.EventHandler(this.libraryBox_SelectedIndexChanged);
            // 
            // pause
            // 
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pause.Location = new System.Drawing.Point(21, 186);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(99, 48);
            this.pause.TabIndex = 9;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(150, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 169);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 264);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.libraryBox);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.playMusic);
            this.Controls.Add(this.chooseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button chooseFile;
        private Button playMusic;
        private Label playLabel;
        private ComboBox libraryBox;
        private Button pause;
        private ListBox listBox1;
    }
}