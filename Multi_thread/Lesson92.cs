using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_thread
{
    internal class Lesson92
    {
        //Hủy luồng
        //==============Vi du 1 ======================
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            CancellationTokenSource cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(new WaitCallback(DoSomeWork), cts.Token);
            Thread.Sleep(4000);
            // tiến hành hủy
            cts.Cancel();
            Console.WriteLine("==> Tiến hành hủy luồng...");
            Thread.Sleep(3000);
            cts.Dispose(); // giải phóng đối tượng
        }

        static void DoSomeWork(object obj)
        {
            CancellationToken token = (CancellationToken)obj;
            for (int i = 0; i < 100000; i++)
            {
                // lắng nghe kiểu thăm dò
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("==> Yêu cầu hủy được thực thi ở vòng lặp thứ " + (i + 1));
                    Console.WriteLine("...");
                    break;
                }
                Thread.SpinWait(50000);
            }
        }


        //==========================Vi du 2 =========================
        //static void Main()
        //{
        //    CancellationTokenSource cts = new CancellationTokenSource();
        //    Console.OutputEncoding = Encoding.UTF8;
        //    StartWebRequest(cts.Token);
        //    Console.WriteLine("==> Nhấn phím bất kỳ để kết thúc: ");
        //    Console.ReadKey();
        //    Console.WriteLine();
        //    cts.Cancel();
        //}

        //static void StartWebRequest(CancellationToken token)
        //{
        //    var target = "https://Youtube.com";
        //    var edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
        //    Console.WriteLine("==> Bắt đầu mở yêu cầu truy cập trang web...");
        //    StartProcess(edgePath, target);
        //    // lắng nghe sử dụng callback
        //    token.Register(() =>
        //    {
        //        StopProcess("msedge");
        //        Console.WriteLine("==> Đã hủy yêu cầu mở trang web.");
        //    });
        //}

        //static void StopProcess(string name)
        //{
        //    try
        //    {
        //        var processes = Process.GetProcessesByName(name);
        //        foreach (var process in processes)
        //        {
        //            process.Kill();
        //        }
        //    }
        //    catch (InvalidOperationException e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
        //static void StartProcess(string path, string target)
        //{
        //    try
        //    {
        //        Process.Start(path, target);
        //    }
        //    catch (InvalidOperationException e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
    }
}
