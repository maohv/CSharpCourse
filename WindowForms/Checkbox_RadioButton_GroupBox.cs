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
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void radioButtonClick(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                MessageBox.Show("Đáp án chính xác");
            }
            else if(radioButton11.Checked || radioButton6.Checked || radioButton9.Checked)
            {
                MessageBox.Show("Đáp án không chính xác");
            }

        }

        private void checkBoxClick(object sender, EventArgs e)
        {
            if (checkBox365.Checked || checkBox360.Checked && 
                (!checkBox300.Checked && !checkBox366.Checked && !checkBox370.Checked))
            {
                MessageBox.Show("Đáp án chính xác");
            }
            else if(checkBox300.Checked || checkBox366.Checked || checkBox370.Checked)
            {
                MessageBox.Show("Đáp án không chính xác");
            }
        }
    }
}
