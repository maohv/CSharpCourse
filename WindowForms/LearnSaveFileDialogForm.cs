using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForms
{
    public partial class LearnSaveFileDialogForm : Form
    {
        public LearnSaveFileDialogForm()
        {
            InitializeComponent();
        }

        private void SaveFileHandler(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.Title = "Lưu file mới";
                var text = textBox1.Text;
                var stream = saveFileDialog.OpenFile();
                var sw = new StreamWriter(stream);
                sw.Write(text);
                sw.Close();
                stream.Close();
                MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
