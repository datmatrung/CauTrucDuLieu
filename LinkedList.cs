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
    public void InDanhSach()
    {
        Node node = head;
        while (node != null)
        {
            Console.Write(node.data + " ");
            node = node.next;
        }
        Console.WriteLine();
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
    public void TimPhanTu(int value)
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
            Console.WriteLine(pos);
        else Console.WriteLine("Khong tim thay");
    }
    public void AddHead(int value)
    {
        if (head == null)
            head = new Node(value);
        Node newNode = new Node(value);
        newNode.next = head;
        head = newNode;
    }
    public void AddTail(int value)
    {
        if (head == null)
            head = new Node(value);
        Node newNode = new Node(value);
        Node last = head;
        while (last.next != null)
            last = last.next;
        last.next = newNode;
        return;
    }
    public void AddAt(int pos, int value)
    {
        if (pos == 0 || head == null)
            AddHead(value);
        int k = 1;
        Node last = head;
        while (last.next != null && k != pos)
        {
            last = last.next;
            k++;
        }
        if (k != pos)
            AddTail(value);
        else
        {
            Node temp = new Node(value);
            temp.next = last.next;
            last.next = temp;
        }
    }
    public void DelHead()
    {
        if (head == null)
            Console.WriteLine("Khong co gi de xoa");
        else head = head.next;
    }
    public void DelTail()
    {
        Node last = head;
        while (last.next.next != null)
        {
            last = last.next;
        }
        last.next = last.next.next;
    }
    public void DelAt(int pos)
    {
        if (pos == 0 || head == null)
            DelHead();
        int k = 1;
        Node last = head;
        while (last.next != null && k != pos)
        {
            last = last.next;
            k++;
        }
        if (k != pos)
            DelTail();
        else last.next = last.next.next;
    }
    public void DaoDanhSach()
    {
        if (head == null)
            Console.WriteLine("Danh sach rong");
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
    public void NhapDanhSach(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            AddTail(arr[i]);
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