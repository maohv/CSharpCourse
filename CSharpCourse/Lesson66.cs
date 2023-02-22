using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson66
    {
        //Queue người dùng tự định nghĩa
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Queue<int> queue = new Queue<int>();
            // thêm vào queue
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);
            Console.WriteLine("==> Các phần tử trong hàng đợi: ");
            queue.Elements();
            // lấy phần tử đầu, cuối queue
            Console.WriteLine("==> Phần tử đầu hàng đợi: " + queue.Peek());
            Console.WriteLine("==> Phần tử cuối hàng đợi: " + queue.Back());
            // xóa bỏ phần tử đầu hàng đợi
            queue.Pop();
            Console.WriteLine("==> Phần tử đầu hàng đợi: " + queue.Peek());
            Console.WriteLine("==> Phần tử cuối hàng đợi: " + queue.Back());
            queue.Push(100);
            // hiển thị các phần tử hiện có trong queue
            Console.WriteLine("==> Các phần tử trong hàng đợi: ");
            queue.Elements();
        }
        class Queue<T>
        {
            private Node<T> first;
            private Node<T> last;
            public Queue()
            {
                first = null;
                last = null;
            }
            // thêm node vào hàng đợi
            public void Push(T data)
            {
                var node = new Node<T>(data);
                if (IsEmpty())
                {
                    first = node;
                    last = node;
                }
                else
                {
                    last.Next = node;
                    last = node;
                }
            }
            // xóa node khỏi hàng đợi
            public void Pop()
            {
                if (IsEmpty())
                {
                    throw new Exception("Queue is empty");
                }
                else
                {
                    var node = first;
                    first = first.Next;
                    node.Next = null;
                }
            }
            // lấy node đầu tiên nhưng không xóa
            public T Peek()
            {
                if (IsEmpty())
                {
                    throw new Exception("Queue is empty");
                }
                else
                {
                    return first.Data;
                }
            }
            // lấy node cuối nhưng không xóa
            public T Back()
            {
                if (IsEmpty())
                {
                    throw new Exception("Queue is empty");
                }
                else
                {
                    return last.Data;
                }
            }
            // kiểm tra rỗng
            public bool IsEmpty()
            {
                return first == null && last == null;
            }
            // liệt kê các phần tử trong hàng đợi
            public void Elements()
            {
                if (!IsEmpty())
                {
                    var x = first;
                    while (x != null)
                    {
                        Console.Write($"{x.Data} -> ");
                        x = x.Next;
                    }
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine("==> Queue is empty.");
                }
            }
        }
        class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }
            public Node()
            {
                Next = null;
            }
            public Node(T data) : this()
            {
                Data = data;
            }
        }
    }
}
