namespace WindowForms
{
    partial class LearnDataGirdView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColFullName,
            this.ColBirthDate,
            this.ColMajor,
            this.ColGpa,
            this.ColRemove});
            this.dataGridViewStudent.Location = new System.Drawing.Point(3, 46);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.Size = new System.Drawing.Size(795, 406);
            this.dataGridViewStudent.TabIndex = 0;
            this.dataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateTableDataHandler);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nạp dữ liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FillDataHandler);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Mã SV";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColFullName
            // 
            this.ColFullName.HeaderText = "Họ Và Tên";
            this.ColFullName.Name = "ColFullName";
            this.ColFullName.ReadOnly = true;
            // 
            // ColBirthDate
            // 
            this.ColBirthDate.HeaderText = "Ngày Sinh";
            this.ColBirthDate.Name = "ColBirthDate";
            this.ColBirthDate.ReadOnly = true;
            // 
            // ColMajor
            // 
            this.ColMajor.HeaderText = "Chuyên Ngành";
            this.ColMajor.Name = "ColMajor";
            this.ColMajor.ReadOnly = true;
            // 
            // ColGpa
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColGpa.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColGpa.HeaderText = "Điểm TB";
            this.ColGpa.Name = "ColGpa";
            this.ColGpa.ReadOnly = true;
            // 
            // ColRemove
            // 
            this.ColRemove.HeaderText = "Xóa";
            this.ColRemove.Name = "ColRemove";
            this.ColRemove.ReadOnly = true;
            this.ColRemove.Text = "Xóa";
            this.ColRemove.ToolTipText = "Xóa bỏ bản ghi này";
            this.ColRemove.UseColumnTextForButtonValue = true;
            // 
            // LearnDataGirdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewStudent);
            this.Name = "LearnDataGirdView";
            this.Text = "LearnDataGirdView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGpa;
        private System.Windows.Forms.DataGridViewButtonColumn ColRemove;
    }
}