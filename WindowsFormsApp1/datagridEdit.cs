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
    public partial class datagridEdit : Form
    {
        public datagridEdit()
        {
            InitializeComponent();
        }

        DataGridViewRowCollection Rows;

        public datagridEdit(DataGridViewRowCollection Rows)
        {
            InitializeComponent();
            this.Rows = Rows;
            foreach(DataGridViewRow row in Rows)
            {
                string id = row.Cells[0].Value + "";
                string name = row.Cells[1].Value + "";
                string gender = row.Cells[2].Value + "";
                string Address = row.Cells[3].Value + "";
                


                data.Rows.Add(id);
            }

            //for(int i = 0; i < Rows.Count; i++)
            //{
            //    int id = int.Parse(Rows[i].Cells[0].Value.ToString());
            //    string name = Rows[i].Cells[1].Value.ToString();
            //    string gender = Rows[i].Cells[2].Value.ToString();
            //    string address = Rows[i].Cells[3].Value.ToString();
            //    Image image = (Image)Rows[i].Cells[4].Value;

            //    data.Rows.Add(id, name, gender, address, image);
            //}
        }
        private void data_SelectionChanged(object sender, EventArgs e)
        {
            if(data.SelectedRows.Count > 0)
            {
                int indexRow = data.SelectedRows[0].Index;
                string id = data.Rows[indexRow].Cells[0].Value.ToString();
                string name = data.Rows[indexRow].Cells[1].Value.ToString();
                string gender = data.Rows[indexRow].Cells[2].Value.ToString();
                string address = data.Rows[indexRow].Cells[3].Value.ToString();
                Image image = (Image)data.Rows[indexRow].Cells[4].Value;

                txtid.Text = id;
                txtname.Text = name;
                txtcombo.Text = gender;
                txtaddress.Text = address;
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count > 0)
            {
                string id = txtid.Text.Trim();
                string name = txtname.Text.Trim();
                string gender = txtcombo.SelectedItem.ToString();
                string address = txtaddress.Text.Trim();
                Image image = picture.Image;

                int indexRow = data.SelectedRows[0].Index;
                data.Rows[indexRow].Cells[0].Value = id;
                data.Rows[indexRow].Cells[1].Value = name;
                data.Rows[indexRow].Cells[2].Value = gender;
                data.Rows[indexRow].Cells[3].Value = address;
                data.Rows[indexRow].Cells[4].Value = image;

            }
        }

        private void data_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
