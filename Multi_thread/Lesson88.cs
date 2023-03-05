using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_thread
{
    public delegate void PrinMessageDelegate(string message);
    class Lesson88
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo đối tượng đóng gói thông tin và hành động cần thực hiện
            var coppy1 = new CoppyFile("input4.txt", "OUTPUT1.OUT", PrintCallback);
            var coppy2 = new CoppyFile("input5.txt", "OUTPUT2.OUT", PrintCallback);
            var coppy3 = new CoppyFile("input3.txt", "OUTPUT3.OUT", PrintCallback);

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
            Console.WriteLine("=> Kết thúc phương thức Main");
        }

        public static void PrintCallback(string message)
        {
            Console.WriteLine("=> Thông điệp nhận từ thread: " + message);
        }
    }
    class CoppyFile
    {
        public string InputFileName { get; set; }
        public string OutputFileName { get; set; }
        private PrinMessageDelegate PrintCallback { get; set; }
        public CoppyFile(string input, string output, PrinMessageDelegate del)
        {
            InputFileName = input;
            OutputFileName = output;
            PrintCallback = del;
        }
        
        public void Coppy()
        {
            try
            {
                var data = File.ReadAllText(InputFileName);
                File.WriteAllText(OutputFileName, data);
                Thread.Sleep(3000);
                PrintCallback($"=> Coppy File {InputFileName} hoàn tất");
            }
            catch (FileNotFoundException e)
            {
                PrintCallback(e.Message);
            }
           
        }
    }
}
