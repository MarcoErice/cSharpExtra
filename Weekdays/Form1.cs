using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekdays
{
    public partial class Form1 : Form
    {
        enum Weekday { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboWeekdays.Items.AddRange(typeof(Weekday).GetEnumNames());
            lstWeekdays.Items.AddRange(typeof(Weekday).GetEnumNames());

            cboWeekdays.SelectedIndex = (int)DateTime.Today.DayOfWeek;
            lstWeekdays.SelectedIndex = (int)DateTime.Today.DayOfWeek;
        }

        private void lstWeekdays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Weekdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cboDay = cboWeekdays.SelectedItem;
            var lstDay = lstWeekdays.SelectedItem;

            lblAreEqual.Text = String.Format("The selected days are equal: {0}", 
            cboDay.Equals(lstDay));

            lblAreEqual.BackColor = cboDay.Equals(lstDay) ? Color.LightGreen :
            Color.LightPink;
        }
    }
}
