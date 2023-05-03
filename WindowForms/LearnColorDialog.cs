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
    public partial class LearnColorDialog : Form
    {
        public LearnColorDialog()
        {
            InitializeComponent();
        }

        private void ChangeColorHandler(object sender, EventArgs e)
        {
            colorDialog.ShowDialog(); // hiển thị lên
            var selectedColor = colorDialog.Color;
            this.BackColor = selectedColor;
        }
    }
}
