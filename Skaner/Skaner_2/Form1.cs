using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using CommonDialog = WIA.CommonDialog;

namespace Skaner_2
{
    public partial class Form1 : Form
    {
        DeviceManager deviceManager = new DeviceManager();
        DeviceInfo deviceInfo;
        ImageFile imageFile = new ImageFile();


        public Form1()
        {
            InitializeComponent();
            ResolutionTrackBar.Minimum = 0;
            ResolutionTrackBar.Maximum = 600;
            ResolutionTrackBar.TickFrequency = 150;
            brightnessTrackBar.Minimum = -100;
            contrastTrackBar.Minimum = -100;
            brightnessTrackBar.Maximum = 100;
            contrastTrackBar.Maximum = 100;
            ResolutionTrackBar.Value = 150;
            resolution.Text = ResolutionTrackBar.Value.ToString();
            contrast.Text = contrastTrackBar.Value.ToString();
            brightness.Text = brightnessTrackBar.Value.ToString();
 

            colorBox.Items.Add("RGB");
            colorBox.Items.Add("Grey scale");
            colorBox.Items.Add("1-bit");

            foreach (DeviceInfo info in deviceManager.DeviceInfos)
            {
                comboBoxDevice.Items.Add(info.Properties["Name"].get_Value());
            }
            colorBox.SelectedIndex = 0;
            comboBoxDevice.SelectedIndex = 0;
        }

        private void comboBoxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            deviceInfo = deviceManager.DeviceInfos[comboBoxDevice.SelectedIndex+1];
            var connectedDevice = deviceInfo.Connect();
            var scannerItem = connectedDevice.Items[1];
            var res = ResolutionTrackBar.Value;
            int color = 0;
            if (colorBox.SelectedIndex== 1)
            {
                color = 2;
            }
            if (colorBox.SelectedIndex == 2)
            {
                color = 4;
            }
            settings(scannerItem, res, 0, 0, 1250 * (res / 150), 1700 * (res / 150), brightnessTrackBar.Value, contrastTrackBar.Value, color);
            imageFile = (ImageFile)scannerItem.Transfer();

            byte[] imageBytes = (byte[])imageFile.FileData.get_BinaryData();
            MemoryStream savedTmp = new MemoryStream(imageBytes);
            Image bitmap = Image.FromStream(savedTmp);

            scanPictureBox.Image = bitmap;


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = " *.BMP| *.BMP | *.JPG | *.JPG | *.GIF | *.GIF | *.PNG | *.PNG | *.TIFF | *.TIFF ";

            saveFileDialog.ShowDialog();

            imageFile.SaveFile(saveFileDialog.FileName);
        }

        private void ResolutionTrackBar_Scroll(object sender, EventArgs e)
        {
            resolution.Text = ResolutionTrackBar.Value.ToString();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            contrast.Text = contrastTrackBar.Value.ToString();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            brightness.Text = brightnessTrackBar.Value.ToString();
        }

        private static void settings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, 
                                        int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

 

        private void scanPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void contrastLabel_Click(object sender, EventArgs e)
        {

        }

        private void colorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contrast_Click(object sender, EventArgs e)
        {

        }

        private void brightness_Click(object sender, EventArgs e)
        {

        }

        private void resolution_Click(object sender, EventArgs e)
        {

        }
    }
}
