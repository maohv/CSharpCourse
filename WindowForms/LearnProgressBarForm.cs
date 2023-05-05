using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForms
{
    public partial class LearnProgressBarForm : Form
    {
        public LearnProgressBarForm()
        {
            InitializeComponent();
        }

        //Ví dụ minh họa
        private void StartPerformdHandler(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            button1.Enabled = false;
            new Thread(() => PerformAction()) { IsBackground = true }.Start();
        }
        private void PerformAction()
        {
            while (progressBar.Value < progressBar.Maximum)
            {
                progressBar.PerformStep();
                Thread.Sleep(100);
            }
            button1.Enabled = true;
        }
    }
}
