using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    //Vòng lặp lồng nhau, lệnh break, continue
    class Lesson13
    {
        static void Main()
        {
            // Vẽ hình vuông
            var data = Console.ReadLine().Split(' ');
            int width = int.Parse(data[0]);
            int height = int.Parse(data[1]);

            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    if (i == 1 || j == 1 || i == width || j == height)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                }
                Console.WriteLine();
            }

            //var data = Console.ReadLine().Split(' ');
            //int a = int.Parse(data[0]);
            //int b = int.Parse(data[1]);
            //int k = int.Parse(data[2]);
            //bool isExisted = false;
            //// tìm số đầu tiên chia hết cho k trong đoạn [a, b]
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % k == 0)
            //    {
            //        Console.WriteLine(i);
            //        isExisted = true;
            //        return;
            //    }
            //}
            //if (!isExisted)
            //{
            //    Console.WriteLine("Khong ton tai kêt qua thoa man");
            //}
            //Console.WriteLine("Cac lenh tiep theo...");
        }
    }
}