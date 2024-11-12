using System.Security.Cryptography;
using System.IO;
using System.Runtime.Intrinsics.Arm;

namespace MDCheck
{
    public partial class Form1 : Form
    {
        OpenFileDialog FileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private static string ComputeHash(string Path, HashAlgorithm algorithm)
        {
            using var stream = File.OpenRead(Path);
            {
                return BitConverter.ToString(algorithm.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
            }
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set FilePath
                string FilePath = FileDialog.FileName;
                // Set the file name
                textBox1.Text = Path.GetFileName(FilePath);

                //Calulate the MD5 checksum
                MD5Checksum.Text = ComputeHash(FilePath, MD5.Create());
                // Calculate the SHA1 checksum
                SHA1Checksum.Text = ComputeHash(FilePath, SHA1.Create());
                // Calculate the SHA256 checksum
                SHA256Checksum.Text = ComputeHash(FilePath, SHA256.Create());
                // Calculate the SHA512 checksum
                SHA512Checksum.Text = ComputeHash(FilePath, SHA512.Create());
            }
        }
    }
}
