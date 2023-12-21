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
    public partial class BDate : Form
    {
        public BDate()
        {
            InitializeComponent();
        }

        private void BDate_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            for (int i = year - 200; i <= year + 200; i++)
            ComboYear.Items.Add(i);

            int month = DateTime.Now.Month;

            ComboYear.SelectedItem = year;
            ComboMonth.SelectedIndex = month - 1; // becuz index when run, itstart from 1 not from 0 
            // example Jan(0) Feb(1) and it start from 1 so it auto select 1(Feb)  and "-1" = auto select 0(Jan)
        }

        private void ComboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateDay();
        }

        private void ComboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateDay();
        }

        private void CreateDay()
        {
            int month = ComboMonth.SelectedIndex + 1;
            int year = int.Parse(ComboYear.SelectedItem.ToString()); // ToString = +""
            if (month > 0)
            {
                int maxDay = DateTime.DaysInMonth(year, month);
                string s = ComboDay.SelectedItem + "";

                ComboDay.Items.Clear();  
                for (int i = 1; i <= maxDay; i++)
                    ComboDay.Items.Add(i);

                if (s != "")
                {
                    int olday = int.Parse(s);

                    if(olday > maxDay)
                    ComboDay.SelectedItem = maxDay;
                
                else
                    ComboDay.SelectedItem = olday;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BDandPT().Show();
            this.Hide();
        }
    }
}
