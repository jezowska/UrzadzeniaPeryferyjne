using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_Kamera
{
    public partial class Form1 : Form
    {
        WebCam webCam = new WebCam();
        public Form1()
        {
            InitializeComponent();
        }

        private void WebCamBox_Click(object sender, EventArgs e){ }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            webCam.Container = WebCamBox;
            webCam.OpenConnection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            webCam.SaveImage();
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
