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
    public partial class BDandPT : Form
    {
        public BDandPT()
        {
            InitializeComponent();
        }

        private void BD_Click(object sender, EventArgs e)
        {
            new BDate().Show();
            this.Hide();
        }

        private void PT_Click(object sender, EventArgs e)
        {
            new ParkingTotkal().Show();
            this.Hide();
        }
    }
}
