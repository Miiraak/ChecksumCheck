namespace MDCheck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            buttonChooseFile = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MD5Checksum = new TextBox();
            SHA1Checksum = new TextBox();
            SHA256Checksum = new TextBox();
            SHA512Checksum = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 30);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonChooseFile
            // 
            buttonChooseFile.Location = new Point(233, 25);
            buttonChooseFile.Name = "buttonChooseFile";
            buttonChooseFile.Size = new Size(79, 30);
            buttonChooseFile.TabIndex = 1;
            buttonChooseFile.Text = "Select";
            buttonChooseFile.UseVisualStyleBackColor = true;
            buttonChooseFile.Click += buttonChooseFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Selected file :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 68);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "MD5        :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "SHA-1     :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 124);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "SHA-256 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 152);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 6;
            label5.Text = "SHA-512 :";
            // 
            // MD5Checksum
            // 
            MD5Checksum.Location = new Point(77, 65);
            MD5Checksum.Multiline = true;
            MD5Checksum.Name = "MD5Checksum";
            MD5Checksum.ReadOnly = true;
            MD5Checksum.Size = new Size(235, 23);
            MD5Checksum.TabIndex = 11;
            // 
            // SHA1Checksum
            // 
            SHA1Checksum.Location = new Point(77, 93);
            SHA1Checksum.Multiline = true;
            SHA1Checksum.Name = "SHA1Checksum";
            SHA1Checksum.ReadOnly = true;
            SHA1Checksum.Size = new Size(235, 23);
            SHA1Checksum.TabIndex = 12;
            // 
            // SHA256Checksum
            // 
            SHA256Checksum.Location = new Point(77, 121);
            SHA256Checksum.Multiline = true;
            SHA256Checksum.Name = "SHA256Checksum";
            SHA256Checksum.ReadOnly = true;
            SHA256Checksum.Size = new Size(235, 23);
            SHA256Checksum.TabIndex = 13;
            // 
            // SHA512Checksum
            // 
            SHA512Checksum.Location = new Point(77, 149);
            SHA512Checksum.Multiline = true;
            SHA512Checksum.Name = "SHA512Checksum";
            SHA512Checksum.ReadOnly = true;
            SHA512Checksum.Size = new Size(235, 23);
            SHA512Checksum.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(324, 180);
            Controls.Add(SHA512Checksum);
            Controls.Add(SHA256Checksum);
            Controls.Add(SHA1Checksum);
            Controls.Add(MD5Checksum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonChooseFile);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "MDCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonChooseFile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox MD5Checksum;
        private TextBox SHA1Checksum;
        private TextBox SHA256Checksum;
        private TextBox SHA512Checksum;
    }
}
