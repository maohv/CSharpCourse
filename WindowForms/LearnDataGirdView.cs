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
            CreateFakeData();
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
            dataGridViewStudent.Rows.Clear(); //Mỗi lần nạp dữ liệu sẽ clear thì k bị trùng
            foreach (var item in Students)
            {
                dataGridViewStudent.Rows.Add(item.ToPropertiesArray());
            }
        }

        private void FillDataHandler(object sender, EventArgs e)
        {
            FillData();
        }

        private void UpdateTableDataHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewStudent.Columns["ColRemove"].Index && e.RowIndex != -1)
            {
                var row = dataGridViewStudent.Rows[e.RowIndex];
                var id = row.Cells["ColId"].Value.ToString();
                var indexToRemove = FindIndex(id);
                if (indexToRemove > -1)
                {
                    var confirmAns = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmAns == DialogResult.Yes)
                    {
                        Students.RemoveAt(indexToRemove);
                        FillData();
                        MessageBox.Show($"Xóa thành công sinh viên mã \"{id}\"!",
                            "Kết quả xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        //phương thức tìm vị trí đối tượng cần xóa theo mã trong danh sách gốc
        private int FindIndex(string id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (id.CompareTo(Students[i].Id) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
