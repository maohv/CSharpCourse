using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Lesson55
    {
        //Struct TimeOnly
        static void Main()
        {
            // tạo đối tượng TimeOnly và hiển thị chuỗi kí tự đại diện tương ứng
            Console.OutputEncoding = Encoding.UTF8;

            TimeOnly time = new TimeOnly(15, 34, 56, 999);
            Console.WriteLine("==> Thông tin của đối tượng vừa tạo: ");
            Console.WriteLine($"{time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine($"Giờ: {time.Hour}");
            Console.WriteLine($"Phút: {time.Minute}");
            Console.WriteLine($"Giây: {time.Second}");
            Console.WriteLine($"Mili giây: {time.Millisecond}");

            // hiển thị string đại diện cho thời gian
            Console.WriteLine($"Thông tin thời gian dạng ngắn: {time.ToShortTimeString()}");
            Console.WriteLine($"Thông tin thời gian dạng dài: {time.ToLongTimeString()}");

            // tạo đối tượng thời gian mới từ đối tượng thời gian có sẵn
            var otherTime = time.AddMinutes(150);
            Console.WriteLine("==> Thông tin thời gian sau khi thêm 150 phút: ");
            Console.WriteLine($"{otherTime.Hour}:{otherTime.Minute}:{otherTime.Second}");
            Console.WriteLine($"Giờ: {otherTime.Hour}");
            Console.WriteLine($"Phút: {otherTime.Minute}");
            Console.WriteLine($"Giây: {otherTime.Second}");
            Console.WriteLine($"Mili giây: {otherTime.Millisecond}");

            // so sánh thời gian
            Console.WriteLine($"{time} == {otherTime} ? {time == otherTime}");
            Console.WriteLine($"{time} != {otherTime} ? {time != otherTime}");
            Console.WriteLine($"{time} > {otherTime} ? {time > otherTime}");
        }
    }
}
