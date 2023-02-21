using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Vi_Du
{
    internal class Lesson57
    {
        //Quản lý file và thư mục
        static void Main()
        {
            //var patch = @"C:\Users\PC\source\repos\C-Course\File_Vi_Du\bin\Debug\TestCreateFile"; //Tạo một thư mục mới TestCreateFile trong đường dẫn
            //DirectoryInfo dir = new DirectoryInfo(patch);
            //dir.Create();

            //=================================

            //DirectoryInfo dir = new DirectoryInfo(@"C:Windows\Web\Wallpaper");
            //Console.WriteLine("===================="); //Xem thông tin thư mục
            //Console.WriteLine("=> Directory infomation: ");
            //Console.WriteLine("FullName: " + dir.FullName);
            //Console.WriteLine("Name: " + dir.Name);
            //Console.WriteLine("Parent: " + dir.Parent);
            //Console.WriteLine("Creation: " + dir.CreationTime);
            //Console.WriteLine("Attributes: " + dir.Attributes);
            //Console.WriteLine("Root: " + dir.Root);

            //var files = dir.GetFiles("*.jpg", SearchOption.AllDirectories); //tìm file jpg trong tất cả các thư mục con
            //foreach (var item in files)
            //{
            //    Console.WriteLine("File name: " + item.Name);
            //    Console.WriteLine("File size: " + item.Length);
            //    Console.WriteLine("File creation: " + item.CreationTime);
            //    Console.WriteLine("File attributes: " + item.Attributes);
            //    Console.WriteLine("====================");
            //}

            //=================================

            //tạo file 
            var filaeName = "input1.txt";
            FileInfo fileInfo = new FileInfo(filaeName);
            var fs = fileInfo.Create();
            fs.Close();
            //fileInfo.Delete(); //xoá file

            //mở file input.txt để đọc ghi dữ liệu
            var fileToOpen = "input.txt";
            FileInfo file = new FileInfo(fileToOpen);
            var reader = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            try
            {
                int data;
                while ((data = reader.ReadByte()) != -1)
                {
                    
                }
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
