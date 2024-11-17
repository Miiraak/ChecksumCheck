namespace ChecksumCheck
{
    partial class Main
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
            textBoxFile = new TextBox();
            buttonChooseFile = new Button();
            MD5Checksum = new TextBox();
            SHA1Checksum = new TextBox();
            SHA256Checksum = new TextBox();
            SHA512Checksum = new TextBox();
            checkBoxMD5 = new CheckBox();
            checkBoxSHA1 = new CheckBox();
            checkBoxSHA256 = new CheckBox();
            checkBoxSHA512 = new CheckBox();
            buttonCheck = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // textBoxFile
            // 
            textBoxFile.Enabled = false;
            textBoxFile.Location = new Point(12, 12);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.PlaceholderText = "Select a file ->";
            textBoxFile.Size = new Size(214, 23);
            textBoxFile.TabIndex = 99;
            textBoxFile.TabStop = false;
            // 
            // buttonChooseFile
            // 
            buttonChooseFile.Location = new Point(232, 7);
            buttonChooseFile.Name = "buttonChooseFile";
            buttonChooseFile.Size = new Size(79, 30);
            buttonChooseFile.TabIndex = 0;
            buttonChooseFile.Text = "Select";
            buttonChooseFile.UseVisualStyleBackColor = true;
            buttonChooseFile.Click += ButtonChooseFile_Click;
            // 
            // MD5Checksum
            // 
            MD5Checksum.Enabled = false;
            MD5Checksum.Location = new Point(90, 47);
            MD5Checksum.Multiline = true;
            MD5Checksum.Name = "MD5Checksum";
            MD5Checksum.Size = new Size(221, 23);
            MD5Checksum.TabIndex = 6;
            // 
            // SHA1Checksum
            // 
            SHA1Checksum.Enabled = false;
            SHA1Checksum.Location = new Point(90, 75);
            SHA1Checksum.Multiline = true;
            SHA1Checksum.Name = "SHA1Checksum";
            SHA1Checksum.Size = new Size(221, 23);
            SHA1Checksum.TabIndex = 7;
            // 
            // SHA256Checksum
            // 
            SHA256Checksum.Enabled = false;
            SHA256Checksum.Location = new Point(90, 103);
            SHA256Checksum.Multiline = true;
            SHA256Checksum.Name = "SHA256Checksum";
            SHA256Checksum.Size = new Size(221, 23);
            SHA256Checksum.TabIndex = 8;
            // 
            // SHA512Checksum
            // 
            SHA512Checksum.Enabled = false;
            SHA512Checksum.Location = new Point(90, 129);
            SHA512Checksum.Multiline = true;
            SHA512Checksum.Name = "SHA512Checksum";
            SHA512Checksum.Size = new Size(221, 23);
            SHA512Checksum.TabIndex = 9;
            // 
            // checkBoxMD5
            // 
            checkBoxMD5.AutoSize = true;
            checkBoxMD5.Enabled = false;
            checkBoxMD5.Location = new Point(6, 47);
            checkBoxMD5.Name = "checkBoxMD5";
            checkBoxMD5.Size = new Size(78, 19);
            checkBoxMD5.TabIndex = 2;
            checkBoxMD5.Text = "MD5        :";
            checkBoxMD5.UseVisualStyleBackColor = true;
            checkBoxMD5.CheckedChanged += CheckBoxMD5_CheckedChanged;
            // 
            // checkBoxSHA1
            // 
            checkBoxSHA1.AutoSize = true;
            checkBoxSHA1.Enabled = false;
            checkBoxSHA1.Location = new Point(6, 77);
            checkBoxSHA1.Name = "checkBoxSHA1";
            checkBoxSHA1.Size = new Size(78, 19);
            checkBoxSHA1.TabIndex = 3;
            checkBoxSHA1.Text = "SHA-1     :";
            checkBoxSHA1.UseVisualStyleBackColor = true;
            checkBoxSHA1.CheckedChanged += CheckBoxSHA1_CheckedChanged;
            // 
            // checkBoxSHA256
            // 
            checkBoxSHA256.AutoSize = true;
            checkBoxSHA256.Enabled = false;
            checkBoxSHA256.Location = new Point(6, 105);
            checkBoxSHA256.Name = "checkBoxSHA256";
            checkBoxSHA256.Size = new Size(78, 19);
            checkBoxSHA256.TabIndex = 4;
            checkBoxSHA256.Text = "SHA-256 :";
            checkBoxSHA256.UseVisualStyleBackColor = true;
            checkBoxSHA256.CheckedChanged += CheckBoxSHA256_CheckedChanged;
            // 
            // checkBoxSHA512
            // 
            checkBoxSHA512.AutoSize = true;
            checkBoxSHA512.Enabled = false;
            checkBoxSHA512.Location = new Point(6, 131);
            checkBoxSHA512.Name = "checkBoxSHA512";
            checkBoxSHA512.Size = new Size(78, 19);
            checkBoxSHA512.TabIndex = 5;
            checkBoxSHA512.Text = "SHA-512 :";
            checkBoxSHA512.UseVisualStyleBackColor = true;
            checkBoxSHA512.CheckedChanged += CheckBoxSHA512_CheckedChanged;
            // 
            // buttonCheck
            // 
            buttonCheck.Enabled = false;
            buttonCheck.Location = new Point(62, 160);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(75, 23);
            buttonCheck.TabIndex = 10;
            buttonCheck.Text = "Check";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += ButtonCheck_Click;
            // 
            // buttonClear
            // 
            buttonClear.Enabled = false;
            buttonClear.Location = new Point(188, 160);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(324, 195);
            Controls.Add(buttonClear);
            Controls.Add(buttonCheck);
            Controls.Add(checkBoxSHA512);
            Controls.Add(checkBoxSHA256);
            Controls.Add(checkBoxSHA1);
            Controls.Add(checkBoxMD5);
            Controls.Add(SHA512Checksum);
            Controls.Add(SHA256Checksum);
            Controls.Add(SHA1Checksum);
            Controls.Add(MD5Checksum);
            Controls.Add(buttonChooseFile);
            Controls.Add(textBoxFile);
            MaximizeBox = false;
            Name = "Form1";
            Text = "ChecksumCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFile;
        private Button buttonChooseFile;
        private TextBox MD5Checksum;
        private TextBox SHA1Checksum;
        private TextBox SHA256Checksum;
        private TextBox SHA512Checksum;
        private CheckBox checkBoxMD5;
        private CheckBox checkBoxSHA1;
        private CheckBox checkBoxSHA256;
        private CheckBox checkBoxSHA512;
        private Button buttonCheck;
        private Button buttonClear;
    }
}
