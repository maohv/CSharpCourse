using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson69
    {
        // Lớp LinkedList<T> danh sách liên kết đôi có sẵn của thư viện
        static void Main()
        {
            Console.OutputEncoding= Encoding.UTF8;
            var elements = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday"};
            LinkedList<string> list = new LinkedList<string>(elements);
            Console.WriteLine($"Số phần tử của DSLK: {list.Count}");
            Console.WriteLine($"Số phần tử đầu của DSLK: {list.First.Value}");
            Console.WriteLine($"Số phần tử cuối của DSLK: {list.Last.Value}");
            Console.WriteLine($"Số phần tử tiếp theo của của phần tử First của DSLK: {list.First.Next.Value}");
            Console.WriteLine($"Phần tử liền trước của phần tử First của DSLK: {(list.First.Previous == null ? "null" : "")}");

            //Lấy node thứ 2 của danh sách
            LinkedListNode<string> node = node = list.First.Next;
            //các phương thức
            list.AddFirst("Sunday"); //thêm đầu của danh sách
            list.AddLast("Friday"); //thêm vào cuối ds
            Console.WriteLine("=> các phần tử trong danh sách hiện tại: ");
            ShowNodes(list);

            list.AddAfter(node, "Saturday");
            list.AddBefore(node, "Saturday");
            Console.WriteLine("=> Các phần tử danh sách liên kết sau khi chèn: ");
            ShowNodes(list);

            //xóa node đầu
            list.RemoveFirst();
            Console.WriteLine("=> Các phần tử danh sách liên kết sau khi xóa node đầu: ");
            ShowNodes(list);
            //xóa node cuối
            list.RemoveLast();
            Console.WriteLine("=> Các phần tử danh sách liên kết sau khi xóa node cuối: ");
            ShowNodes(list);
            //xóa node được chỉ định
            list.Remove("Wednesday");
            Console.WriteLine("=> Các phần tử danh sách liên kết sau khi xóa phần tử được chỉ định: ");
            ShowNodes(list);

            //kiểm tra một giá trị tồn tại hay không?
            Console.WriteLine("=> 'Friday' có tồn tại trong DSLK? " + list.Contains("Friday"));
            Console.WriteLine("=> 'Monday' có tồn tại trong DSLK? " + list.Contains("Monday"));
        }
        private static void ShowNodes(LinkedList<string> list)
        {
            
            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }
    }
}
