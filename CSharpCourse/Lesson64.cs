using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson64
    {
        static void Main()
        {
            //Danh sách liên kết đôi

            Console.OutputEncoding = Encoding.UTF8;
            DoubleLinkedList<string> list = new DoubleLinkedList<string>();
            // chèn đầu DSLK
            list.AddFirst("One");
            list.AddFirst("Two");
            list.AddFirst("Three");
            list.AddFirst("Four");
            // chèn cuối DSLK
            list.AddLast("Five");
            list.AddLast("Six");
            Console.WriteLine("==> Các node trong danh sách liên kết trước khi chèn: ");
            list.ShowNodes();
            list.ShowNodesReverse();
            // chèn sau note X 
            list.AddAfterX("Nine", "One");
            list.AddAfterX("Nine", "Six");
            Console.WriteLine("==> Các node trong danh sách liên kết sau khi chèn: ");
            list.ShowNodes();
            list.ShowNodesReverse();
        }
    }

    class DoubleLinkedList<T>
    {
        public Node<T> First { get; set; } // node đầu danh sách
        public Node<T> Last { get; set; } // node cuối danh sách

        public DoubleLinkedList()
        {
            First = null;
            Last = null;
        }

        // chèn vào đầu danh sách liên kết
        public void AddFirst(T data)
        {
            var p = new Node<T>(data); // tạo node cần chèn
            if (IsEmpty()) // nếu danh sách rỗng
            {
                First = p; // gán p cho first
                Last = p; // gán p cho last
            }
            else // nếu danh sách không rỗng
            {
                p.Next = First; // cập nhật next của p
                First.Prev = p; // cập nhật prev của first
                First = p; // cập nhật lại node first mới
            }
        }

        // chèn vào cuối danh sách liên kết
        public void AddLast(T data)
        {
            var p = new Node<T>(data);
            if (IsEmpty()) // nếu danh sách rỗng
            {
                First = p; // first và last cùng tham chiếu tới p
                Last = p;
            }
            else // nếu danh sách không rỗng
            {
                Last.Next = p; // cập nhật next của last
                p.Prev = Last; // cập nhật prev của p
                Last = p; // cập nhật lại node last mới
            }
        }

        // chèn sau node x bất kì
        public void AddAfterX(T data, T x)
        {
            if (IsEmpty()) // nếu danh sách rỗng
            {
                AddFirst(data); // chèn vào đầu
            }
            else
            {
                var currentNode = First;
                while (currentNode != null) // tìm node có giá trị x
                {
                    if (currentNode.Data.Equals(x)) // nếu tìm thấy
                    {
                        if (currentNode == Last) // node hiện tại là node cuối
                        {
                            AddLast(data); // chèn vào cuối
                        }
                        else
                        {
                            var p = new Node<T>(data); // tạo node p
                            p.Next = currentNode.Next; // cập nhật next của p
                            p.Next.Prev = currentNode; // cập nhật prev của p
                            currentNode.Next.Prev = p; // cập nhật node prev của node sau p
                            currentNode.Next = p; // cập nhật node next của currentNode
                        }
                        break;
                    }
                    currentNode = currentNode.Next;
                }
            }
        }

        // kiểm tra danh sách rỗng không
        public bool IsEmpty()
        {
           return First == null && Last == null;
        }

        // hiển thị danh sách các node
        public void ShowNodes()
        {
            var x = First;
            while (x != null)
            {
                Console.Write($"{x.Data} -> ");
                x = x.Next;
            }
            Console.WriteLine("null");
        }

        // hiển thị danh sách theo thứ tự cuối -> đầu
        public void ShowNodesReverse()
        {
            var x = Last;
            while (x != null)
            {
                Console.Write($"{x.Data} <- ");
                x = x.Prev;
            }
            Console.WriteLine("null");
        }
    }
    class Node<T>
    {
        public T Data { get; set; } // dữ liệu của node
        public Node<T> Next { get; set; } // địa chỉ node tiếp theo
        public Node<T> Prev { get; set; } // địa chỉ node liền trước

        public Node()
        {
            Next = null;
            Prev = null;
        }

        public Node(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
