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
    public partial class ParkingTotkal : Form
    {
        public ParkingTotkal()
        {
            InitializeComponent();
        }

        DateTime checkIn, checkOut;
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            checkIn = DateTime.Now;
            textCheckin.Text = checkIn.ToString("dddd, dd-MMM-yyyy:ss tt");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkOut = DateTime.Now;
            textCheckout.Text = checkOut.ToString("dddd, dd-MMM-yyyy:ss tt");

            string din = checkIn.ToString("dd-MMM-yyyy HH:mm");
            string dout =checkOut.ToString("dd-MMM-yyyy HH:mm");


            //Add(1)
            DateTime cin = DateTime.ParseExact(din, "dd-MMM-yyyy HH:mm", null);

            //Add(2)
            DateTime cout = DateTime.ParseExact(dout, "dd-MMM-yyyy HH:mm", null);

            //double totalM = (checkOut - checkIn).TotalMinutes;
            //textResults.Text = totalM.ToString();



            //Add(1)
            //textResults.Text = $"{din}\r\n{dout}";

            ////(Add(2)
            //double totalM = (cout - cin).TotalMinutes;

            //int day = (int)(cout - cin).TotalDays;
            //int hour = (cout - cin).Hours;
            //int minute = (cout - cin).Minutes;
            //textResults.Text = $"{day}day, {hour}h, {minute}min";

            ///$"{ totalM}\r\n" + ( after "...Text = (here)" )
            ////

            ///(Add 3)
            int h = (int)(cout - cin).TotalHours;
            int m = (cout - cin).Minutes;

            string r = $"YOU ARE HER FOR {h}H and {m}Min\r\n" + $"Free for 1H...\r\n";

            h--;
            double payment = 0;
            if(h < 0)
            {
                h = 0;m = 0;

            }
            else
            {
                payment = h * 2000;
                if (m > 1)
                    if (m <= 15)
                        payment += 500;
                    else if (m <= 30)
                        payment += 1000;
                    else if (m <= 45)
                        payment += 2000;
            }

            r += $"You Pay For {h}H and {m}Min\r\n" + $"Payment = {payment:#,##0,## រាល}\r\n";

            textResults.Text = r;

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = textResults.Text;
            e.Graphics.DrawString(text, new Font("Microsoft Sans Serif",16,FontStyle.Regular),Brushes.Black,0,0);

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
