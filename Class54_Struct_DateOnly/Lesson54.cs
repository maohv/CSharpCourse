using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Lesson54
    {
        //Struct DateOnly
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; //Hiển thị tiếng việt
            DateOnly dateOnly = new DateOnly(2025, 10, 15);
            Console.WriteLine("==> Thông tin về đối tượng DateOnly vừa tạo: ");
            Console.WriteLine($"Ngày: {dateOnly.Day}");
            Console.WriteLine($"Tháng: {dateOnly.Month}");
            Console.WriteLine($"Năm: {dateOnly.Year}");
            // thực hiện các thao tác khác
            Console.WriteLine("==> Sau khi thêm 17 ngày vào đối tượng Date ở trên: ");
            var otherDate = dateOnly.AddDays(17);
            Console.WriteLine($"Ngày: {otherDate.Day}");
            Console.WriteLine($"Tháng: {otherDate.Month}");
            Console.WriteLine($"Năm: {otherDate.Year}");
            Console.WriteLine("==> Sau khi thêm 17 tháng vào đối tượng Date ở trên: ");
            otherDate = dateOnly.AddMonths(17);
            Console.WriteLine($"Ngày: {otherDate.Day}");
            Console.WriteLine($"Tháng: {otherDate.Month}");
            Console.WriteLine($"Năm: {otherDate.Year}");
            // So sánh các đối tượng của DateOnly

            Console.WriteLine($"{dateOnly} > {otherDate} ? {dateOnly > otherDate}");
            Console.WriteLine($"{dateOnly} == {otherDate} ? {dateOnly == otherDate}");
            Console.WriteLine($"{dateOnly} <= {otherDate} ? {dateOnly <= otherDate}");
            Console.WriteLine(dateOnly.ToLongDateString()); //Hiển thị tên tháng và thứ trong tuần
        }
    }
}
