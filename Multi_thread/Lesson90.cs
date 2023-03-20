using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_thread
{
    class Lesson90
    {
        // Luồng foreground và background
        static void Main()
        {
            Thread thread = new Thread(new ThreadStart(DoSomeTask));
            thread.IsBackground = true;
            Console.WriteLine(thread.IsBackground);
            thread.Start();
        }

        static void DoSomeTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Task finished.");
        }
    }
}
