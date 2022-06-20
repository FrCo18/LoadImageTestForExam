using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestExam
{
    public partial class PatientProfileForm : Form
    {
        public PatientProfileForm()
        {
            InitializeComponent();
            fillPictureBox();
        }

        private void fillPictureBox()
        {
            var pathToImage = Program.app.patient.Users.image_path;

            if (pathToImage != null)
            {
                pictureBox.Image = Image.FromFile(pathToImage);
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {

                string path = Program.app.getUserFilesPath();
                Regex regex = new Regex(@".*\\(?<imagePath>.*)");
                var imageName = regex.Match(openFileDialog.FileName);

                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                string pathToImage = path + imageName.Groups["imagePath"].Value;
                fileInfo.CopyTo(pathToImage, true);

                var patient = Program.app.patient;
                patient.Users.image_path = pathToImage;
                Program.app.db.SaveChanges();

                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить изображение!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
