using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multi_Thread
{
    internal class Lesson86
    {
        //Ví dụ về đa luồng
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var obj = new Lesson86();
            Thread instanceThread = new Thread(new ThreadStart(obj.InstanceMethod));
            Thread staticThread = new Thread(new ThreadStart(Staticmethod));
            Console.WriteLine("Trước khi gọi khởi chạy 2 thread.");
            instanceThread.Start();
            staticThread.Start();
            Console.WriteLine("=> Kết thúc chương trình.");
        }
        static void Staticmethod()
        {
            Console.WriteLine("==> Phương thức static đang thực thi bởi một thread khác.");
            Thread.Sleep(5000);
            Console.WriteLine("==> Phương thức static đã kết thúc");
        }
        void InstanceMethod()
        {
            Console.WriteLine("==> Phương thức instance đang thực thi bởi một thread khác.");
            Thread.Sleep(7000);
            Console.WriteLine("==> Phương thức instance đã kết thúc");
        }
    }
}
