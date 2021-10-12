using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            oWebCam.OpenConnection();
        }
        WebCam oWebCam;
        private void Form1_Load(object sender, EventArgs e)
        {
            oWebCam = new WebCam();
            oWebCam.Container = pictureBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oWebCam.SaveImage();
        }
    }
}
