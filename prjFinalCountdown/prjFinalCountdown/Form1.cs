using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFinalCountdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //calculate the time until the end of the year
            DateTime today = DateTime.Now;
            DateTime endOfYear = new DateTime(today.Year, 6, 30);
            TimeSpan timeUntilEndOfYear = endOfYear - today;
            //display the time until the end of the year
            lblLAbel.Text = "There are " + timeUntilEndOfYear.Days + " days left in this schoolyear.";

            //display as countdown
            lblHoursMinutesSeconds.Text = "That is " + timeUntilEndOfYear.Days.ToString() + " days and " + timeUntilEndOfYear.Hours.ToString() + ":" + timeUntilEndOfYear.Minutes.ToString() + ":" + timeUntilEndOfYear.Seconds.ToString();

            //display total number of seconds
            lblTotalSeconds.Text = "That is " + Math.Floor(timeUntilEndOfYear.TotalSeconds).ToString() + " seconds";
            //display total number of minutes
            lblTotalMinutes.Text = "That is " + Math.Floor(timeUntilEndOfYear.TotalMinutes).ToString() + " minutes";
            //dispay total number of hours
            lblTotalHours.Text = "That is " + Math.Floor(timeUntilEndOfYear.TotalHours).ToString() + " hours";
        }
    }
}
