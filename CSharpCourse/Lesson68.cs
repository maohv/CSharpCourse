using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson68
    {
        //Tìm hiểu và sử dụng lớp Queue<T>
        static void Main()
        {
            Console.OutputEncoding= Encoding.UTF8;

            //Queue<string> queue = new Queue<string>();
            Queue<string> queue1 = new Queue<string>(new List<string>() {"one", "true"," three" });
            //queue.Enqueue("A"); //Thêm phần tử vào cuối queue
            //queue.Dequeue(); //Xóa phần tử ở đầu queue
            //queue.Peek(); //lấy phần tử ở đầu nhưng k xóa
            Console.WriteLine("==> Số lượng phần tử trong hàng đợi: " + queue1.Count);
            queue1.Enqueue("four");
            queue1.Enqueue("five");
            queue1.Enqueue("six");
            Console.WriteLine("==> Phần tử đầu hàng đợi: " + queue1.Peek());
            Console.WriteLine("==> Phần tử vừa bị xóa: " + queue1.Dequeue());
            var elements = queue1.ToArray();
            Console.WriteLine("==> Các phần tử hiện có trong hàng đợi: ");
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
            queue1.Clear();
            Console.WriteLine("==> Số lượng phần tử trong hàng đợi: " + queue1.Count);
        }
    }
}
