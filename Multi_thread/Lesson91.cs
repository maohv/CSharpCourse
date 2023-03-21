using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_thread
{
    internal class Lesson91
    {
        //Tạm ngưng và ngăt luồng
        static void Main()
        {
            Console.OutputEncoding= Encoding.UTF8;
            Thread thread = new Thread(SleepIndefinitely);
            thread.Name = "Sleping Thread 1";
            thread.Start();
            Thread.Sleep(2000);
            thread.Interrupt(); //ngắt

            Thread.Sleep(1000);
            thread = new Thread(SleepIndefinitely);
            thread.Name = "Sleping Thread 2";
            thread.Start();
            Thread.Sleep(3000);
            thread.Abort(); //Hủy đi
        }

        static void SleepIndefinitely()
        {
            Console.WriteLine($"==> Thread {Thread.CurrentThread.Name} chuẩn bị ngủ vô thời hạn.");
            try
            {
                Thread.Sleep(Timeout.Infinite); //ngủ vô thời hạn
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine($"==> Thread {Thread.CurrentThread.Name} được đánh thức.");
            }
            catch(ThreadAbortException)
            {
                Console.WriteLine($"==> Thread {Thread.CurrentThread.Name} đã bị hủy.");
            }
            finally
            {
                Console.WriteLine($"==> Thread {Thread.CurrentThread.Name} thực hiện các công việc trong khối finally.");
            }
            Console.WriteLine($"==> Thread {Thread.CurrentThread.Name} kết thúc bình thường.");
            Console.WriteLine("=======================================");
          
        }
    }
}
