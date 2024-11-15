using System.Security.Cryptography;

namespace MDCheck
{
    public partial class Main : Form
    {
        private string filePath = string.Empty;

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is called when the user clicks the "Choose File" button. It opens a file dialog and sets the file path to the selected file. It also enables all checkboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                textBoxFile.Text = Path.GetFileName(filePath);

                foreach (var checkBox in new CheckBox[] { checkBoxMD5, checkBoxSHA1, checkBoxSHA256, checkBoxSHA512 })
                {
                    checkBox.Enabled = true;
                }
            }
        }

        private void CheckBoxMD5_CheckedChanged(object sender, EventArgs e)
        {
            MD5Checksum.Clear();
            MD5Checksum.Enabled = checkBoxMD5.Checked;
            VerifyCheckBox();
        }

        private void CheckBoxSHA1_CheckedChanged(object sender, EventArgs e)
        {
            SHA1Checksum.Clear();
            SHA1Checksum.Enabled = checkBoxSHA1.Checked;
            VerifyCheckBox();
        }

        private void CheckBoxSHA256_CheckedChanged(object sender, EventArgs e)
        {
            SHA256Checksum.Clear();
            SHA256Checksum.Enabled = checkBoxSHA256.Checked;
            VerifyCheckBox();
        }

        private void CheckBoxSHA512_CheckedChanged(object sender, EventArgs e)
        {
            SHA512Checksum.Clear();
            SHA512Checksum.Enabled = checkBoxSHA512.Checked;
            VerifyCheckBox();
        }

        /// <summary>
        /// This method is called when the user clicks the "Check" button. It verifie if at least one checkbox is checked.
        /// </summary>
        private void VerifyCheckBox()
        {
            buttonCheck.Enabled = checkBoxMD5.Checked || checkBoxSHA1.Checked || checkBoxSHA256.Checked || checkBoxSHA512.Checked;
        }

        /// <summary>
        /// This method computes the hash of a file using the specified algorithm.
        /// </summary>
        /// <param name="Path">The absolute path of the file to compute.</param>
        /// <param name="algorithm">The wanted algorithm.</param>
        /// <returns></returns>
        private static string ComputeHash(string filePath, HashAlgorithm algorithm)
        {
            using var stream = File.OpenRead(filePath);
            {
                return BitConverter.ToString(algorithm.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
            }
        }

        /// <summary>
        /// This method is called when the user clicks the "Check" button. It computes the hash of the file and compares it with the hash in the textbox. If they match, the textbox background color is green, otherwise it is red.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            buttonCheck.Enabled = false;
            buttonClear.Enabled = true;

            if (checkBoxMD5.Checked)
            {
                MD5Checksum.BackColor = MD5Checksum.Text == ComputeHash(filePath, MD5.Create()) ? Color.Green : Color.Red;
            }
            if (checkBoxSHA1.Checked)
            {
                SHA1Checksum.BackColor = SHA1Checksum.Text == ComputeHash(filePath, SHA1.Create()) ? Color.Green : Color.Red;
            }
            if (checkBoxSHA256.Checked)
            {
                SHA256Checksum.BackColor = SHA256Checksum.Text == ComputeHash(filePath, SHA256.Create()) ? Color.Green : Color.Red;
            }
            if (checkBoxSHA512.Checked)
            {
                SHA512Checksum.BackColor = SHA512Checksum.Text == ComputeHash(filePath, SHA512.Create()) ? Color.Green : Color.Red;
            }
        }

        /// <summary>
        /// This method is called when the user clicks the "Clear" button. It clears all textboxes and disables all checkboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                    textBox.BackColor = Color.White;
                }
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = false;
                }

                buttonClear.Enabled = false;
                buttonCheck.Enabled = false;
            }
        }
    }
}
