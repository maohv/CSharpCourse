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
    public partial class ComboBox : Form
    {
        public List<string> Brands { get; set; } = new List<string>(
               new string[]
               {
                   "Honda", "Toyota", "Nissan", "Audi"
               });

        public ComboBox()
        {

            InitializeComponent();
            //comboBoxBrand.DataSource = Brands;
            comboBoxBrand.SelectedIndex = -1;
            comboBoxBrand.Items.AddRange(Brands.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn hãng: " + comboBoxBrand.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxBrand.Items.Add(textBoxBrands.Text);
            textBoxBrands.Text = " ";
        }
    }
}
