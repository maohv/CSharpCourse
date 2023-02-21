using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson63
    {
        //Danh sách liên kết đơn
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            LinkedList<string> list = new LinkedList<string>();
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
            // chèn sau giá trị x
            list.AddAfterX("Nine", "One");
            list.AddAfterX("Nine", "Six");
            Console.WriteLine("==> Các node trong danh sách liên kết sau khi chèn: ");
            list.ShowNodes();
        }
    }

    class LinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }

        public LinkedList()
        {
            First = null;
            Last = null;
        }

        // thêm node vào đầu danh sách lk
        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data);
            if (IsEmpty())
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
        }

        // thêm node vào cuối danh sách lk
        public void AddLast(T data)
        {
            var newNode = new Node<T>(data);
            if (IsEmpty())
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
        }

        // thêm node vào sau node x danh sách lk
        public void AddAfterX(T data, T x)
        {
            if (IsEmpty())
            {
                AddFirst(data);
            }
            else
            {
                var currentNode = First;
                while (currentNode != null)
                {
                    if (currentNode.Data.Equals(x))
                    {
                        if (currentNode == Last)
                        {
                            AddLast(data);
                        }
                        else
                        {
                            var newNode = new Node<T>(data);
                            newNode.Next = currentNode.Next;
                            currentNode.Next = newNode;
                        }
                        break;
                    }
                    currentNode = currentNode.Next;
                }
            }
        }

        // kiểm tra danh sách rỗng
        public bool IsEmpty()
        {
            return First == null && Last == null;
        }

        // hiển thị danh sách các node hiện có
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
    }

    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node()
        {
            Next = null;
        }
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
