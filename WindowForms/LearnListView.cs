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
    public partial class LearnListView : Form
    {
        public LearnListView()
        {
            InitializeComponent();
            AddImages();
        }

        private void AddImages()
        {
            var generalPath = @"C:\Windows\Web\Wallpaper\ThemeD\";
            ImageList imageListSmall = new ImageList();
            imageListSmall.Images.Add(new Bitmap(generalPath + "img32.jpg"));
            imageListSmall.Images.Add(new Bitmap(generalPath + "img33.jpg"));
            imageListSmall.Images.Add(new Bitmap(generalPath + "img34.jpg"));
            imageListSmall.Images.Add(new Bitmap(generalPath + "img35.jpg"));
            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(64, 64);
            imageListLarge.Images.Add(new Bitmap(generalPath + "img32.jpg"));
            imageListLarge.Images.Add(new Bitmap(generalPath + "img33.jpg"));
            imageListLarge.Images.Add(new Bitmap(generalPath + "img34.jpg"));
            imageListLarge.Images.Add(new Bitmap(generalPath + "img35.jpg"));
            listView1.SmallImageList = imageListSmall;
            listView1.LargeImageList = imageListLarge;
        }
    }
}
