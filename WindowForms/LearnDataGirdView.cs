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
    public partial class LearnDataGirdView : Form
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public LearnDataGirdView()
        {
            InitializeComponent();
        }
        private void CreateFakeData()
        {
            Students.Add(new Student("SV101","Trần Trung Đức", "CNTT", new DateTime(2004,4,15), 3f));
            Students.Add(new Student("SV102","Hoàng Thị Mai", "CNTT", new DateTime(2007,6,18), 4f));
            Students.Add(new Student("SV103","Nguyễn Văn Quyết", "CNTT", new DateTime(2005,4,22), 2.25f));
            Students.Add(new Student("SV104","Bùi Xuân Tiến", "CNTT", new DateTime(2001,5,12), 3.45f));
        }
        private void FillData()
        {
            foreach (var item in Students)
            {

            }
        }

        private void FillDataHandler(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
