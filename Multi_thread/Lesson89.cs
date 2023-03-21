using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Multi_thread
{
    internal class Lesson89
    {
        //Ví dụ về tiến trình và quản lý tiến trình trong Windows
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var target = "https://youtube.com.vn";
            var otherTarget = "https://google.com.vn";
            var edgePatch = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            startProcess(edgePatch, otherTarget);
            Console.WriteLine("=> Nhấn phím bất kỳ để kết thúc");
            Console.ReadKey();

            StopProcess("firefox");
        }

        private static void StopProcess(string name)
        {
            try
            {
                var processes = Process.GetProcessesByName(name);
                foreach (var process in processes)
                {
                    var threads = process.Threads;
                    foreach (ProcessThread thread in threads)
                    {
                        Console.WriteLine("Thread Id: " + thread.Id);
                    }
                    process.Kill();
                }
            }
            catch (InvalidOperationException e)
            {

                Console.WriteLine(e);
            }
        }

        static void startProcess(string path, string target)
        {
            try
            {
                Process.Start(path, target);
            }
            catch (InvalidOperationException e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
