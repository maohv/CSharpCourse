using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson43
    {
        //Kiểu enum
        static void Main()
        {

            Season season = Season.Spring;
            Console.WriteLine($"Gia tri so nguyen cua {season} la {(uint)season}");
            var otherSeason = (Season)11u;
            Console.WriteLine($"Hang so enum cua 11 la {otherSeason}");
            var mySeason = (Season)30u;
            Console.WriteLine($"Hang so enum cua 30 la {mySeason}");
            // kết quả:
            // Gia tri so nguyen cua Spring la 10
            // Hang so enum cua 11 la Summer
            // Hang so enum cua 30 la Winter
        }
    }

    enum Season //: uint chỉ định kiểu dữ liệu, mặc định int
    {
        Spring = 10,
        Summer,
        Autumn = 200,
        Winter = 30
    }
}
