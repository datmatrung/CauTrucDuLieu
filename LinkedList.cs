using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Node
    {
        int number;
        Node next;

        public Node()
        {
            number = 0;
            next = null;
        }
        public Node(int a_number)
        {
            number = a_number;
            next = null;
        }

        public Node AddHead(int value)
        {
            Node newNode = new Node(value);
            newNode.next = this;
            return newNode;
        }
        public Node AddLast(int value)
        {
            Node newNode = new Node(value);
            next = newNode;
            return newNode;
        }
    }
    class LinkedList
    {
        Node head;
        Node tail;
        public LinkedList()
        {
            head = null;
            tail = null;
        }
        public void AddHead(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                tail = head;
            }
            else
                head = head.AddHead(value);
        }
        public void AddLast(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                tail = head;
            }
            else
                tail = tail.AddLast(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddHead(15);
            list.AddHead(5);
            list.AddHead(25);
            Console.WriteLine("Done Add Head");
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            Console.WriteLine("Done Add Last");
            Console.ReadLine();
        }
    }
}