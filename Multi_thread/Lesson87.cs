using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multi_thread
{
    internal class Lesson87
    {
        //Tạo và truyền dữ liệu vào luồng khi khởi chạy
        static void Main()
        {
            Console.OutputEncoding= Encoding.UTF8;
            // Tạo đối tượng đóng gói thông tin và hành động cần thực hiện
            var coppy1 = new CoppyFile("input1.txt", "OUTPUT1.OUT");
            var coppy2 = new CoppyFile("input2.txt", "OUTPUT2.OUT");
            var coppy3 = new CoppyFile("input3.txt", "OUTPUT3.OUT");

            //tạo ra các luồng để thực thi song song việc sao chép file
            Thread CoppyThread1 = new Thread(new ThreadStart(coppy1.Coppy));
            Thread CoppyThread2 = new Thread(new ThreadStart(coppy2.Coppy));
            Thread CoppyThread3 = new Thread(new ThreadStart(coppy3.Coppy));

            //Kích hoạt các luồng
            CoppyThread1.Start();
            CoppyThread2.Start();
            CoppyThread3.Start();

            //Điều thread về main thread
            CoppyThread1.Join();
            CoppyThread2.Join();
            CoppyThread3.Join();

            //Thông báo kết thúc
            Console.WriteLine("=> Tất cả sao chép file hoàn tất.");
        }
    }

    class CoppyFile
    {
        public string InputFileName { get; set; }
        public string OutputFileName { get; set; }
        public CoppyFile(string input, string output)
        {
            InputFileName = input;
            OutputFileName = output;
        }

        public void Coppy()
        {
            var data = File.ReadAllText(InputFileName);
            File.WriteAllText(OutputFileName, data);
            Thread.Sleep(5000);
            Console.WriteLine($"=> Coppy File {InputFileName} hoàn tất");
        }
    }
}
