using System;
class Node
{
    public int data;
    public Node next;
    public Node(int value)
    {
        data = value;
        next = null;
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
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
        }
    }
    public void NhapDanhSach(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            AddHead(arr[i]);
    }
    public void InDanhSach()
    {
        Node last = head;
        while (last != null)
        {
            Console.Write(last.data + " ");
            last = last.next;
        }
        Console.WriteLine();
    }
    public void DaoNguoc()
    {
        Node current = null;
        Node previous = null;
        while (head != null)
        {
            current = head;
            head = head.next;
            current.next = previous;
            previous = current;
        }
        head = current;
    }
    public int DemDanhSach()
    {
        int count = 0;
        Node last = head;
        while (last != null)
        {
            count++;
            last = last.next;
        }
        return count;
    }
    public int TimPhanTu(int value)
    {
        int pos = 0;
        Node last = head;
        while (last != null)
        {
            if (last.data == value) break;
            else pos++;
            last = last.next;
        }
        if (pos < DemDanhSach())
            return pos;
        else return -1;
    }
    public void ThemPhanTu(int pos, int value)
    {
        if (pos <= 0 || head == null)
            AddHead(value);
        else if (pos >= DemDanhSach())
        {
            Node newNode = new Node(value);
            Node last = head;
            while (last.next != null)
                last = last.next;
            last.next = newNode;
        }
        else
        {
            int k = 1;
            Node last = head;
            while (last.next != null && k != pos)
            {
                last = last.next;
                k++;
            }
            Node newNode = new Node(value);
            newNode.next = last.next;
            last.next = newNode;
        }
    }
    public void XoaPhanTu(int pos)
    {
        if (head == null)
            Console.WriteLine("Khong co gi de xoa");
        else if (pos <= 0)
            head = head.next;
        else if (pos >= DemDanhSach())
        {
            Node last = head;
            while (last.next.next != null)
                last = last.next;
            last.next = last.next.next;
        }    
        else
        {
            int k = 1;
            Node last = head;
            while (last.next != null && k != pos)
            {
                last = last.next;
                k++;
            }
            last.next = last.next.next;
        }
    }
    public void SuaPhanTu(int pos, int value)
    {
        if (head == null)
            AddHead(value);
        else if (pos <= 0)
            head.data = value;
        else if (pos >= DemDanhSach())
        {
            Node last = head;
            while (last.next != null)
                last = last.next;
            last.data = value;
        }
        else
        {
            int k = 0;
            Node last = head;
            while (last.next != null && k != pos)
            {
                last = last.next;
                k++;
            }
            last.data = value;
        }
    }
}
class Program
{
    static void Main()
    {
        int[] arr = { 45, 12, 89, 34, 56, 15 };
        LinkedList List = new LinkedList();
        List.NhapDanhSach(arr);
        List.InDanhSach();
        Console.ReadLine();
    }
}
