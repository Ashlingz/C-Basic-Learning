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
    public partial class back : Form
    {
        public back()
        {
            InitializeComponent();
        }

        private void Sumvalue_Load(object sender, EventArgs e)
        {
          
        }

        private void sumb_Click(object sender, EventArgs e)
        {

            double Value1 = double.Parse(value1.Text);
            double Value2 = double.Parse(value2.Text);
            double Value3 = Value1 + Value2;

            string r = $"{Value1} + { Value2} = { Value3}";
            value3.AppendText(r + "\r\n");
            value1.Clear();
            value2.Clear();
            value1.Focus();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new All().Show();
            this.Hide();
        }

        private void value2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
