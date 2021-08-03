using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ConvertMp3ToWaveGraphPic
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        public GraphForm(TimeSpan startPosition,TimeSpan endPosition)
        {
            InitializeComponent();

            var start = startPosition;
            var end = endPosition;

            menuStrip1.Enabled = false;
            PrintChart(start,end);
        }


        private async void PrintChart(TimeSpan start, TimeSpan end)
        {

            chart1.Series.Add("wave");
            chart1.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["wave"].ChartArea = "ChartArea1";
            chart1.BackColor = Color.Black;
            chart1.ChartAreas["ChartArea1"].BackColor = Color.Black;

            NAudio.Wave.WaveChannel32 wave = new NAudio.Wave.WaveChannel32(ConvertMp3ToWaveGraphImage.WaveFileReader);

            wave.CurrentTime = wave.CurrentTime.Add(start);
            var pos1 = wave.Position;
            wave.CurrentTime = wave.CurrentTime.Add(end);
            var pos2 = wave.Position;


            byte[] buffer = new byte[1000000];
            int read = 0;
            //long pos = 0;
            wave.Position = pos1;
            while (wave.Position < pos2)
            {
                read = await wave.ReadAsync(buffer, 0, 1000000);

                for (int i = 0; i < read / 16; i++)
                {
                    chart1.Series["wave"].Points.Add(BitConverter.ToSingle(buffer, i * 4));
                }
            }
            menuStrip1.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";
            saveFileDialog.FileName = "Sample.png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 2)
                            chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);

                        else if (saveFileDialog.FilterIndex == 1)
                            chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);

                        DisposeEverything();
                    }
                    else
                        MessageBox.Show("Given Path does not exist");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void DisposeEverything()
        {
            GraphForm.ActiveForm.Dispose();
        }



    }
}
