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
    public partial class EditInfo : Form
    {
        public EditInfo()
        {
            InitializeComponent();
        }
    
        ListView.ListViewItemCollection Items;
        ImageList images;
        List<Image> pic;
        public EditInfo(ListView.ListViewItemCollection Items, ImageList images, List<Image>pic )
        {
            InitializeComponent();
            this.Items = Items;
            this.images = images;
            this.pic = pic;
            for (int i = 0; i <Items.Count; i++)
            {
                ListViewItem item = (ListViewItem)Items[i].Clone();
                imageList1.Images.Add(images.Images[i]);
                item.ImageIndex = i;
                list.Items.Add(item);
            }
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

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list.SelectedItems.Count > 0)
            {
                int index = list.SelectedItems[0].Index;
                string id = list.Items[index].SubItems[1].Text;
                string name = list.Items[index].SubItems[2].Text;
                string gender = list.Items[index].SubItems[3].Text;
                string address = list.Items[index].SubItems[4].Text;
                Image image = pic[index];

                txtID.Text = id;
                txtName.Text = name;
                txtGender.Text = gender;
                txtAddress.Text = address;
                picture.Image = image;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if(list.SelectedItems != null)
            {
                int index = list.SelectedItems[0].Index;
                string id = txtID.Text.Trim();
                string name = txtID.Text.Trim();
                string gender = txtGender.Text.Trim();
                string address = txtAddress.Text.Trim();
                Image image = picture.Image;

                list.Items[index].SubItems[1].Text = id;
                list.Items[index].SubItems[2].Text = name;
                list.Items[index].SubItems[3].Text = gender;
                list.Items[index].SubItems[4].Text = address;
                imageList1.Images[index] = new Bitmap(image, 64, 64);

                Items[index].SubItems[1].Text = id;
                Items[index].SubItems[2].Text = name;
                Items[index].SubItems[3].Text = gender;
                Items[index].SubItems[4].Text = address;
                images.Images[index] = new Bitmap(image, 64, 64);
                pic[index] = image;

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
