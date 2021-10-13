using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamera;

namespace Camera
{
    public partial class Form1 : Form
    {
        WebCam webCam = new WebCam();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            webCam.Container = pictureBox1;
            webCam.OpenConnection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            webCam.SaveImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webCam.Load();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            webCam.OpenSettings();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            webCam.StartRecording();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            webCam.StopRecording();
        }

    }
}
