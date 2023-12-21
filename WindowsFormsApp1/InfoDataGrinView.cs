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
    public partial class InfoDataGrinView : Form
    {
        public InfoDataGrinView()
        {
            InitializeComponent();
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
      

        private void data_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
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

            data.Rows.Add(id, name, gender, address, image);

            idtxt.Clear();
            nametxt.Clear();
            addresstxt.Clear();
            rMale.Checked = false;
            rFemale.Checked = false;
            rOther.Checked = false;
            picture.Image = Properties.Resources.photo_2022_02_23_14_30_27;
            idtxt.Focus();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditt_Click(object sender, EventArgs e)
        {

                new datagridEdit(data.Rows).Show();
            
        }
    }
}
