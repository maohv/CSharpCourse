using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Vi_Du
{
    class lesson58
    {
        //Đọc ghi file text
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; //hiển thị tiếng việt
            /*try 
            {
                //ví dụ 1: 
                var data = File.ReadAllLines("input.txt"); //lấy dữ liệu trong file input.txt
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine(e); 
            //} */

            /* //ví dụ 2
            FileInfo file = new FileInfo("input.txt");
            using (var streamRearder = file.OpenText()) //using thực hiện xong đóng đối tượng này lại khi kết thúc, tránh xảy ra ngoại lệ
            {
                while (true)
                {
                    var line = streamRearder.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                }
            }*/

            var data = new string[]
            {
                "Đây là dòng dữ liệu thứ nhất.",
                "Đây là dòng dữ liệu thứ hai.",
                "Đây là dòng dữ liệu thứ thứ ba."
            };
            /*File.WriteAllLines("output.txt",data);*/ //tự động ghi dữ liệu mảng data vào file output

            FileInfo file = new FileInfo("output.txt");
            using (Stream stream = file.OpenWrite()) //Open(FileMode.Append, FileAccess.Write)) ghi đè thêm vào cuối file
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (var item in data)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }
    }
}
