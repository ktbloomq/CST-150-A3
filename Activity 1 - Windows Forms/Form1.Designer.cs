namespace Activity_1___Windows_Forms
{
    partial class Form1
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
            this.printText = new System.Windows.Forms.Button();
            this.clickCount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printText
            // 
            this.printText.Location = new System.Drawing.Point(250, 71);
            this.printText.Name = "printText";
            this.printText.Size = new System.Drawing.Size(87, 23);
            this.printText.TabIndex = 0;
            this.printText.Text = "Print Text";
            this.printText.UseVisualStyleBackColor = true;
            this.printText.Click += new System.EventHandler(this.printTest_Click);
            // 
            // clickCount
            // 
            this.clickCount.AutoSize = true;
            this.clickCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickCount.Location = new System.Drawing.Point(130, 9);
            this.clickCount.Name = "clickCount";
            this.clickCount.Size = new System.Drawing.Size(207, 18);
            this.clickCount.TabIndex = 1;
            this.clickCount.Text = "the lope has been clicked 0 times";
            this.clickCount.Click += new System.EventHandler(this.clickCount_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Activity_1___Windows_Forms.Properties.Resources.RunningLope_267;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(363, 128);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clickCount);
            this.Controls.Add(this.printText);
            this.Name = "Form1";
            this.Text = "Form Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printText;
        private System.Windows.Forms.Label clickCount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

