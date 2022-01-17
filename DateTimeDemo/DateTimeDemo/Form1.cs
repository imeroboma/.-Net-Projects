using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDate_Click(object sender, EventArgs e) => Display();

        private void Display()
        {
            lblDate.Text = DateTime.Now.ToLongDateString(); //just the date
            lbltime.Text = DateTime.Now.ToShortTimeString(); //only time
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Display();
        }
          //user selected date
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime partyDay = dateTimePicker1.Value.Date; //date only
            //how many days to party
            TimeSpan difference = partyDay.Subtract(DateTime.Today);
            //lblMessage.Text = "The party is on" + partyDay.ToLongDateString();
            //partyDay.ToLongDateString();
            lblMessage.Text = $"The party is on {partyDay.DayOfWeek}, {partyDay.ToLongDateString()}";
        }
    }
}
