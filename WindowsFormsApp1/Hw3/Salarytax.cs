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
    public partial class Salarytax : Form
    {
        public Salarytax(double SAlary)
        {
            InitializeComponent();
            this.Salary = SAlary;
            salarybox.Text = Salary + "";
        }


        double Salary;
        private void button1_Click(object sender, EventArgs e)
        {
           
           // double Salary = double.Parse(salarybox.Text);
            double Bonus = double.Parse(bonusbox.Text);
            int Spouse = int.Parse(spousebox.Text);
            int Children = int.Parse(childrenbox.Text);

            if (Salary >= 0 && Bonus >= 0)
            {
                if (Spouse >= 1) 
                    Spouse = 1;
                else
                    Spouse = 0;

                if (Children >= 9)
                    Children = 9;
                else if (Children <= 0)
                         Children = 0;

                spousebox.Text = Spouse + "";
                childrenbox.Text = Children + "";

                double Tax, Lastsalary;
                double Family = (Spouse + Children) * 150000;

                Salary -= Family;

                if (Salary <= 1200000)
                    Tax = 0;
                else if (Salary <= 2000000)
                    Tax = Salary * 0.05 - 60000;
                else if (Salary <= 8500000)
                    Tax = Salary * 0.1 - 160000;
                else if (Salary <= 1250000)
                    Tax = Salary * 0.15 - 5850000;
                else
                    Tax = Salary * 0.2 - 1210000;

                Tax += Bonus * 0.2;
                Lastsalary = (Salary + Family + Bonus)-Tax;

                txt1.Text = Tax.ToString("#,##0,## R");
                txt2.Text = Lastsalary.ToString("#,##0,## R");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // new All().Show();
           // this.Hide();
        }

        private void salarybox_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == 13)
            {
                button1_Click(sender, e);
                bonusbox.Focus();
            }
        }

        private void txt2_Click(object sender, EventArgs e)
        {

        }
    }
}
