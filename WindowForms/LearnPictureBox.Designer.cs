namespace WindowForms
{
    partial class LearnPictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnPictureBox));
            this.pictureBoxWallpaper = new System.Windows.Forms.PictureBox();
            this.comboBoxSelectedImage = new System.Windows.Forms.ComboBox();
            this.comboBoxSizeMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWallpaper
            // 
            this.pictureBoxWallpaper.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWallpaper.Image")));
            this.pictureBoxWallpaper.Location = new System.Drawing.Point(4, 56);
            this.pictureBoxWallpaper.Name = "pictureBoxWallpaper";
            this.pictureBoxWallpaper.Size = new System.Drawing.Size(838, 434);
            this.pictureBoxWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWallpaper.TabIndex = 0;
            this.pictureBoxWallpaper.TabStop = false;
            // 
            // comboBoxSelectedImage
            // 
            this.comboBoxSelectedImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectedImage.FormattingEnabled = true;
            this.comboBoxSelectedImage.Items.AddRange(new object[] {
            "AutoSize",
            "CenterImage",
            "Normal",
            "StretchImage",
            "Zoom"});
            this.comboBoxSelectedImage.Location = new System.Drawing.Point(120, 12);
            this.comboBoxSelectedImage.Name = "comboBoxSelectedImage";
            this.comboBoxSelectedImage.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSelectedImage.TabIndex = 1;
            this.comboBoxSelectedImage.SelectedIndexChanged += new System.EventHandler(this.selectSizeModeChangedHandle);
            // 
            // comboBoxSizeMode
            // 
            this.comboBoxSizeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSizeMode.FormattingEnabled = true;
            this.comboBoxSizeMode.Items.AddRange(new object[] {
            "img32.jpg",
            "img33.jpg",
            "img34.jpg",
            "img35.jpg"});
            this.comboBoxSizeMode.Location = new System.Drawing.Point(622, 12);
            this.comboBoxSizeMode.Name = "comboBoxSizeMode";
            this.comboBoxSizeMode.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSizeMode.TabIndex = 2;
            this.comboBoxSizeMode.SelectedIndexChanged += new System.EventHandler(this.SelectImageChangedHandle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Image";
            // 
            // LearnPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSizeMode);
            this.Controls.Add(this.comboBoxSelectedImage);
            this.Controls.Add(this.pictureBoxWallpaper);
            this.Name = "LearnPictureBox";
            this.Text = "LearnPictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWallpaper;
        private System.Windows.Forms.ComboBox comboBoxSelectedImage;
        private System.Windows.Forms.ComboBox comboBoxSizeMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}