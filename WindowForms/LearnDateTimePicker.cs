using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForms
{
    public partial class LearnDateTimePicker : Form
    {
        public LearnDateTimePicker()
        {
            InitializeComponent();
        }

        private void DateSelectedHandler(object sender, EventArgs e)
        {
            var selectedDateTime = dateTimePicker.Value;
            //MessageBox.Show("Date time: "+ selectedDateTime.ToString());
            var dayOfWeek = selectedDateTime.DayOfWeek;
            MessageBox.Show("Date time: " + dayOfWeek);
        }
    }
}
