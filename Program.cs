using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class node
    {
        int data;
        node next;

        public node()
        {
            next = null;
            data = 0;
        }

        public node(int value)
        {
            next = null;
            data = value;
        }

        public static node AddTail(node head, int value)
        {
            node p;
            node temp = new node(value);
            if (head == null)
            {
                head = temp;
            }
            else
            {
                p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = temp;
            }
            return head;
        }

        public static node AddHead(node head, int value)
        {
            node temp = new node(value);
            if (head == null)
            {
                head = temp;
            }
            else
            {
                temp.next = head;
                head = temp;
            }
            return head;
        }

        public static node AddAt(node head, int value, int position)
        {
            if (position == 0 || head == null)
            {
                head = AddHead(head, value);
            }
            else
            {
                int k = 1;
                node p = head;
                while (p != null && k != position)
                {
                    p = p.next;
                    ++k;
                }
                if (k != position)
                {
                    head = AddTail(head, value);
                }
                else
                {
                    node temp = new node(value);
                    temp.next = p.next;
                    p.next = temp;
                }
            }
            return head;
        }

        public static node DelHead(node head)
        {
            if (head == null)
            {
                Console.WriteLine("Khong co gi de xoa");
            }
            else
            {
                head = head.next;
            }
            return head;
        }

        public static node DelTail(node head)
        {
            node p = head;
            while (p.next.next != null)
            {
                p = p.next;
            }
            p.next = p.next.next;
            return head;
        }

        public static node DelAt(node head, int position)
        {
            if (position == 0 || head == null)
            {
                head = DelHead(head);
            }
            else
            {
                int k = 1;
                node p = head;
                while (p.next.next != null && k != position)
                {
                    p = p.next;
                    ++k;
                }
                if (k != position)
                {
                    head = DelTail(head);
                }
                else
                {
                    p.next = p.next.next;
                }
            }
            return head;
        }

        public static int Get(node head, int index)
        {
            int k = 0;
            node p = head;
            while (p != null && k != index)
            {
                p = p.next;
            }
            return p.data;
        }

        public static int Search(node head, int value)
        {
            int position = 0;
            for (node p = head; p != null; p = p.next)
            {
                if (p.data == value)
                {
                    return position;
                }
                ++position;
            }
            return -1;
        }

        public static node DelByVal(node head, int value)
        {
            int position = Search(head, value);
            while (position != -1)
            {
                DelAt(head, position);
                position = Search(head, value);
            }
            return head;
        }

        public static void Traverser(node head)
        {
            Console.WriteLine();
            for (node p = head; p != null; p = p.next)
            {
                Console.WriteLine($"{p.data} ");
            }
        }

        public static node InitHead()
        {
            node head;
            head = null;
            return head;
        }

        public static int Length(node head)
        {
            int length = 0;
            for (node p = head; p != null; p = p.next)
            {
                ++length;
            }
            return length;
        }

        public static node Input()
        {
            node head = InitHead();
            int n, value;
            do
            {
                Console.WriteLine("Nhap so luong phan tu n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Nhap gia tri can them: ");
                value = int.Parse(Console.ReadLine());
                head = AddTail(head, value);
            }
            return head;
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}