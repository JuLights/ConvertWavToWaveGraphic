using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertMp3ToWaveGraphPic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sT = TimeSpan.Parse(startTextBox.Text);
                var eT = TimeSpan.Parse(endTextBox.Text);
                var graphForm = new GraphForm(sT, eT);
                graphForm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "default trim from 00:00 to 00:10 (10 second)"/* + ex.Message*/);
                var graphForm = new GraphForm(new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 10));
                graphForm.ShowDialog();
            }

            this.Dispose();

        }
    }
}
