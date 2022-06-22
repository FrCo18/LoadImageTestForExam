using System.Drawing;
using System.Windows.Forms;

namespace TestExam
{
    public partial class LvImagesForm : Form
    {
        public LvImagesForm()
        {
            InitializeComponent();
            loadUsers();
        }

        private void loadUsers()
        {
            lvUsers.Items.Clear();

            var users = Program.app.db.Users;

            ImageList imageList = new ImageList();
            lvUsers.SmallImageList = imageList;
            imageList.ImageSize = new Size(100, 100);

            int i = 0;

            foreach (var user in users)
            {
                if (user.image_path != null)
                {
                    var image = Image.FromFile(user.image_path);
                    imageList.Images.Add(image);
                }
                else
                {
                    Bitmap image = new Bitmap(30, 30);

                    imageList.Images.Add(image);
                }

                ListViewItem item = new ListViewItem(
                    new string[] { "", user.login }
                    );

                item.Tag = user;
                item.ImageIndex = i;

                i++;

                lvUsers.Items.Add(item);

            }

            lvUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
