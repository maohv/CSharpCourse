﻿using System;
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
    public partial class LearnButtonForm : Form
    {
        public LearnButtonForm()
        {
            InitializeComponent();
        }

        private void btnLoginClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn nút đăng nhập");
        }
    }
}
