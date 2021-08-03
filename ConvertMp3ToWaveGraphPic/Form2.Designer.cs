
namespace ConvertMp3ToWaveGraphPic
{
    partial class Form2
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
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(77, 46);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(100, 20);
            this.startTextBox.TabIndex = 1;
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(77, 81);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(100, 20);
            this.endTextBox.TabIndex = 2;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(36, 49);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(29, 13);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Start";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(36, 84);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(26, 13);
            this.endLabel.TabIndex = 5;
            this.endLabel.Text = "End";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Trim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select time for Wave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ex: 00:05:30 (5min 30sec)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ex: 00:05:40 (5min 40sec)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(this.startTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}