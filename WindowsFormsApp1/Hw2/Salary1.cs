using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Salary1 : Form
    {
        public Salary1()
        {
            InitializeComponent();
          
        }

        private double totalSalary;
       
        private void clear_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(totalh.Text);


            if (Total >= 0)
            {
                double basicSalary = 100;//, totalSalary;
                if (Total >= 100)
                {
                    double ext1, ext2;
                    double bra1 = 1.25, bra2 = 1.5;
                    double bSalary;

                    double ext = Total - 100;
                    if (ext <= 20)
                    {
                        ext1 = ext;
                        ext2 = 0;
                    }
                    else
                    {
                        ext1 = 20;
                        ext2 = ext - 20;
                    }
                    bSalary = (ext1 * bra1) + (ext2 * bra2);
                    totalSalary = basicSalary + bSalary;

                    string result  = "Extra Time1   =" + ext1 + "H \r\n";
                           result += "Extra Time2  =" + ext2 + "H \r\n";
                           result += "Bonus Rate1  =" + bra1.ToString("$0.00") + "H\r\n";
                           result += "Bonus Rate2  =" + bra2.ToString("$0.00") + "H\r\n";
                           result += "Bonus Salary =" + bSalary.ToString("$0.00") + "\r\n";
                           result += "Basic Salary =" + basicSalary.ToString("$0.00") + "\r\n";
                           result += "________________________________________\r\n";
                           result += "Total Salary =" + totalSalary.ToString("$0.00") + "\r\n";
                    show.Text = result;
                }

                else
                {
                    double lr = 0.5;
                    double LSalary = (100 - Total) * lr;
                    totalSalary = basicSalary - LSalary;

                    string re = "Basic Salary =" + basicSalary.ToString("$0.00") + " \r\n";
                    re += "Lost Rate    =" + lr.ToString("$0.00") + "H \r\n";
                    re += "Lost Salary  =" + LSalary.ToString("$0.00") + "H\r\n";
                    re += "________________________________________\r\n";
                    re += "Total Salary =" + totalSalary.ToString("$0.00") + "\r\n";
                    show.Text = re;
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new All().Show();
            this.Hide();
        }

        private void ttax_Click(object sender, EventArgs e)
        {
           double rate=double.Parse (Interaction.InputBox("Enter Rate Dollar", "Rate Dollar", "4100",-1,-1)) ;


            new Salarytax(totalSalary*rate).Show();
            
        }
    }
}
