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
    }
    class LinkedList
    {
        Node head;
        public LinkedList()
        {
            head = null;
        }
        public void AddHead(int value)
        {
            if (head == null)
                head = new Node(value);
            else
                head = head.AddHead(value);
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
            Console.WriteLine("Done");
        }
    }
}
