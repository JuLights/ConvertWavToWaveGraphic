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
using NAudio;
using NAudio.Wave;

namespace ConvertMp3ToWaveGraphPic
{
    public partial class ConvertMp3ToWaveGraphImage : Form
    {

        public static NAudio.Wave.WaveFileReader WaveFileReader = null;
        

        public ConvertMp3ToWaveGraphImage()
        {
            InitializeComponent();

            printGraphToolStripMenuItem.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "wav file (*.wav)|*.wav";
            if (open.ShowDialog() != DialogResult.OK) return;

            //waveViewer1.SamplesPerPixel = 100;
            try
            {
                //waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(open.FileName);
                WaveFileReader = new NAudio.Wave.WaveFileReader(open.FileName);

                var form2 = new Form2();
                form2.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show(this, $"Please choose .wav format file, {ex.Message}");
            }
            
        }

        private void Mp3ToWav(string mp3File,string output)
        {
            using (Mp3FileReader reader = new Mp3FileReader(mp3File))
            {
                using(WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(reader))
                {
                    WaveFileWriter.CreateWaveFile(output, pcmStream);
                }
            }
        }


        private void mp3ToWavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "mp3 File (*.mp3)|*.mp3";
            if (open.ShowDialog() != DialogResult.OK) return;

            string output = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + $"{open.SafeFileName}" + "-" + "converted.wav";
            Mp3ToWav(open.FileName, output);

            
        }

        private void printGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WaveFileReader != null)
            {
                GraphForm graphForm = new GraphForm();
                graphForm.Show();
            }
            else
            {
                MessageBox.Show(this,"First of all, choose .wav file or use .mp3 to wav converter");
            }
            
        }

        private void ConvertMp3ToWaveGraphImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
