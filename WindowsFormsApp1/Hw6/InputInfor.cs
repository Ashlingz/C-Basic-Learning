using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputInfor : Form
    {
        public InputInfor()
        {
            InitializeComponent();
        }

        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            DialogResult result = openfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image image = Image.FromFile(openfile.FileName);
                picture.Image = image;
            }
        }
        List<Image> pic = new List<Image>();
      
        private void button1_Click(object sender, EventArgs e)
        {
            string id = idtxt.Text.Trim();
            string name = nametxt.Text.Trim();
            string gender;
            if (rMale.Checked)
                gender = "Male";
            else if (rFemale.Checked)
                gender = "Female";
            else
                gender = "Other";
            string address = addresstxt.Text.Trim();
            Image image = picture.Image;

            imageList1.Images.Add(image);
            pic.Add(image);
           

            string[] row = { "",id, name, gender, address};
            ListViewItem item = new ListViewItem(row);
            item.ImageIndex = imageList1.Images.Count -1;
            list.Items.Add(item);

            idtxt.Clear();
            nametxt.Clear();
            addresstxt.Clear();
            picture.Image = Properties.Resources.photo_2022_02_23_14_30_27;
            idtxt.Focus();
        }

        private void btnEditt_Click(object sender, EventArgs e)
        {
            new EditInfo(list.Items,imageList1,pic).Show();
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
