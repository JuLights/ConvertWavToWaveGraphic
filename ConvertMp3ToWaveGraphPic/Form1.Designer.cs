
namespace ConvertMp3ToWaveGraphPic
{
    partial class ConvertMp3ToWaveGraphImage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mp3ToWavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.printGraphToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openToolStripMenuItem.Text = "Wav to graph";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // printGraphToolStripMenuItem
            // 
            this.printGraphToolStripMenuItem.Name = "printGraphToolStripMenuItem";
            this.printGraphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printGraphToolStripMenuItem.Text = "Print Graph";
            this.printGraphToolStripMenuItem.Click += new System.EventHandler(this.printGraphToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mp3ToWavToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // mp3ToWavToolStripMenuItem
            // 
            this.mp3ToWavToolStripMenuItem.Name = "mp3ToWavToolStripMenuItem";
            this.mp3ToWavToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mp3ToWavToolStripMenuItem.Text = "Mp3 to Wav";
            this.mp3ToWavToolStripMenuItem.Click += new System.EventHandler(this.mp3ToWavToolStripMenuItem_Click);
            // 
            // waveViewer1
            // 
            this.waveViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveViewer1.Location = new System.Drawing.Point(0, 24);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(260, 143);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 1;
            this.waveViewer1.WaveStream = null;
            // 
            // ConvertMp3ToWaveGraphImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 167);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConvertMp3ToWaveGraphImage";
            this.Text = "ConvertMp3ToWaveGraphImage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConvertMp3ToWaveGraphImage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mp3ToWavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printGraphToolStripMenuItem;
        //private NAudio.Gui.WaveViewer waveViewer2;
    }
}

