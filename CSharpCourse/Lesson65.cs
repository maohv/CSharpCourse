using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson65
    {
        //Stack người dùng tự định nghĩa
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("==> Stack rỗng? " + stack.IsEmpty());

            // thêm các phần tử vào stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // lấy phần tử đầu stack
            Console.WriteLine("==> Phần tử đầu stack: " + stack.Peek());
            // xóa phần tử đầu stack
            stack.Pop();
            Console.WriteLine("==> Phần tử đầu stack: " + stack.Peek());
            stack.Pop();
            Console.WriteLine("==> Phần tử đầu stack: " + stack.Peek());

            stack.Push(100);
            Console.WriteLine("==> Các phần tử sau khi push(100): ");
            while (!stack.IsEmpty())
            {
                Console.Write($" <- {stack.Top.Data}");
                stack.Top = stack.Top.Next;
            }
            Console.WriteLine();

            // xóa các phần tử của stack
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine("==> Stack rỗng? " + stack.IsEmpty());
        }

    }
    class Stack<T>
    {
        public Node<T> Top { get; set; }
        public Stack()
        {
            Top = null;
        }

        public void Push(T data) // thêm phần tử vào đầu stack
        {
            var node = new Node<T>(data);
            node.Next = Top;
            Top = node;
        }

        public void Pop() // xóa phần tử khỏi đầu stack
        {
            if (IsEmpty())
            {
                throw new Exception("Stack Empty");
            }
            else
            {
                var top = Top;
                Top = Top.Next;
                top.Next = null;
            }
        }

        public T Peek() // lấy phần tử đầu stack
        {
            if (!IsEmpty())
            {
                return Top.Data;
            }
            throw new Exception("Stack Empty");
        }

        public bool IsEmpty() // kiểm tra stack rỗng
        {
            return Top == null;
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
