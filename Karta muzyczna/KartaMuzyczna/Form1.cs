using System;
using System.IO;
using System.Threading;
using System.Text;
using System.Runtime.InteropServices;
using System.Media;
using System.Text;
using SlimDX.DirectSound;
using SlimDX.Multimedia;
using WMPLib;

namespace KartaMuzyczna
{
    public partial class Form1 : Form
    {
        bool playing = false;
        bool recording = false;
        bool paused = false;
        string fileName;
        DirectSound directSound = new DirectSound();
        SoundBufferDescription description = new SoundBufferDescription();
        SoundPlayer soundPlayer = new SoundPlayer();
        WindowsMediaPlayer wmplayer;
        SecondarySoundBuffer soundBuffer;
        FileStream fileStream = new FileStream("generated.wav", FileMode.Create);

        public Form1()
        {
            InitializeComponent();
            libraryBox.Items.Add("PlaySound");
            libraryBox.Items.Add("WindowsMediaPlayer");
            libraryBox.Items.Add("SlimDX");
        }


        private void chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;
                soundPlayer = null;
                if (!fileName.EndsWith(".wav"))
                {
                    if (!fileName.EndsWith(".mp3"))
                    {
                        MessageBox.Show("Plik powinien mieæ rozszerzenie .wav lub .mp3");
                        fileName = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie uda³o siê otworzyæ pliku");
            }


            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStream);

            byte[] wave = reader.ReadBytes(24);

            fileStream.Position = 0;
            //nag³ówek
            int chunkID = reader.ReadInt32();
            int fileSize = reader.ReadInt32();
            var fileFormat = Encoding.Default.GetString(wave);
            string format = fileFormat.Substring(8, 4);
            string subchunk1ID = fileFormat.Substring(12, 8);
            int subchunk1Size = reader.ReadInt32();

            reader.Close();

            string chunkIDStr = $"Chunk ID: {chunkID}";
            string fileSizeStr = $"Chunk size: {fileSize}";
            string fileFormatStr = $"Format: {format}";
            string subchunk1IDStr = $"Subchunk ID: {subchunk1ID}";
            string subchunk1SizeStr = $"Subchunk Size ID: {subchunk1Size}";

            listBox1.Items.Clear();
            listBox1.Items.AddRange(new string[]
             {
                "Nag³ówek: ", chunkIDStr, fileSizeStr, fileFormatStr,
                "\tStruktura audio:",subchunk1IDStr
                ,subchunk1SizeStr
            });
        }



        private void playMusic_Click(object sender, EventArgs e)
        {
            if(playing == false)
            {
                if(fileName != null)
                {
                    playing = true;
                    playMusic.Text = "Stop";
                    if (libraryBox.SelectedIndex == 0 && fileName.EndsWith(".wav"))
                    {
                        soundPlayer = new SoundPlayer(fileName);
                        soundPlayer.Play();
                    }
                    else if(libraryBox.SelectedIndex == 1 && fileName.EndsWith(".mp3"))
                    {
                        wmplayer = new WMPLib.WindowsMediaPlayer();
                        wmplayer.URL = fileName;
                        wmplayer.controls.play();
                    }
                    else if (libraryBox.SelectedIndex == 2 && fileName.EndsWith(".wav"))
                    {

                        WaveStream wave;
                        wave = new WaveStream(fileName);
                        description.SizeInBytes = (int)wave.Length;
                        description.Flags = BufferFlags.None;
                        description.Format = wave.Format;
                        byte[] data = new byte[description.SizeInBytes];
                        wave.Read(data, 0, (int)wave.Length);
                        soundBuffer = new SecondarySoundBuffer(directSound, description);

                        directSound.SetCooperativeLevel(this.Handle, CooperativeLevel.Priority);
                        
                        soundBuffer.Write(data, 0, LockFlags.None);
                        soundBuffer.Play(0, 0);
                    }

                    else
                    {
                        MessageBox.Show("Wybierz odpowiedni¹ metodê i/lub wczytaj plik!");
                    }
                }
            }
            else if (playing == true)
            {
                if (libraryBox.SelectedIndex == 0)
                {
                    soundPlayer.Stop();
                    pause.Text = "Pause";
                }
                if (libraryBox.SelectedIndex == 1)
                {
                    wmplayer.controls.stop();
                }
                if(libraryBox.SelectedIndex == 2)
                {
                    soundBuffer.Stop();
                }
                
                playing = false;
                playMusic.Text = "Play";
            }
        }

        private void libraryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (paused == false)
            {
                paused = true;
                pause.Text = "Continue";
                if (libraryBox.SelectedIndex == 1)
                {
                    wmplayer.controls.pause();
                }
                if (libraryBox.SelectedIndex == 2)
                {
                   
                }
            }
            else if(paused == true)
            {
                pause.Text = "Pause";
                paused = false;
                if (libraryBox.SelectedIndex == 1)
                {
                    wmplayer.controls.play();
                }
                if (libraryBox.SelectedIndex == 2)
                {

                }
            }
            
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void stop_Click(object sender, EventArgs e)
        {

        }
    }
}