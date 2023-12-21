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
    public partial class ComboTesting : Form
    {
        public ComboTesting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string text = textBox1.Text.Trim();
                if (text != "")
                {
                    //for(int i = 0; i < comboCountry.Items.Count; i++)
                    //{
                    //    string oldItem = comboCountry.Items[i].ToString().Trim();
                    //    if(oldItem.ToLower() == text.ToLower())
                    //    {
                    //        MessageBox.Show("Item already exist");
                    //        return;
                    //    }

                    //}

                    foreach (string oldItem in comboBox1.Items)
                    {
                        if (oldItem.Trim().ToLower() == text.ToLower())
                        {
                            MessageBox.Show("Item already exist");
                            return;
                        }
                    }

                    comboBox1.Items.Add(text);
                    textBox1.Clear();
                    comboBox1.SelectedItem = text;
                }
                else
                    MessageBox.Show("Please input data");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
