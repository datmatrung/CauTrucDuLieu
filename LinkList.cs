using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class DanhSach
    {
        public int number;
        public DanhSach next;

        public DanhSach()
        {
            number = 0;
            next = null;
        }

        public DanhSach(int value)
        {
            number = value;
            next = null;
        }
    }
    class Program
    {
        static Boolean NhapPhanTu(DanhSach p)
        {
            Console.Write("Nhap phan tu: ");
            string number = Console.ReadLine();
            if (number != string.Empty)
            {
                p.number = int.Parse(number);
                return true;
            }
            return false;
        }
        static DanhSach ThemPhanTu(DanhSach L, DanhSach p)
        {
            if (L == null) L = p;
            else
            {
                DanhSach q = L;
                while (q.next != null) q = q.next;
                q.next = p;
            }
            return L;
        }
        static void InDanhSach(DanhSach L)
        {
            DanhSach p = L;
            while (p != null)
            {
                Console.Write($"{p.number} ");
                p = p.next;
            }
            Console.WriteLine();
        }
        static int DemDanhSach(DanhSach L)
        {
            int dem = 0;
            DanhSach p = L;
            while (p != null)
            {
                dem++;
                p = p.next;
            }
            return dem;
        }
        static int TimPhanTu(DanhSach L, int value)
        {
            int pos = 0;
            DanhSach p = L;
            while (p != null)
            {
                if (p.number == value) break;
                else pos++;
                p = p.next;
            }
            return pos;
        }
        static DanhSach AddHead(DanhSach L, int value)
        {
            DanhSach temp = new DanhSach(value);
            if (L == null)
            {
                L = temp;
            }
            else
            {
                temp.next = L;
                L = temp;
            }
            return L;
        }

        static DanhSach AddTail(DanhSach L, int value)
        {
            DanhSach temp = new DanhSach(value);
            if (L == null)
            {
                L = temp;
            }
            else
            {
                DanhSach p = L;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = temp;
            }
            return L;
        }

        static DanhSach AddAt(DanhSach L, int value, int pos)
        {
            if (pos == 0 || L == null)
            {
                L = AddHead(L, value);
            }
            else
            {
                int k = 1;
                DanhSach p = L;
                while (p.next != null && k != pos)
                {
                    p = p.next;
                    k++;
                }
                if (k != pos)
                {
                    L = AddTail(L, value);
                }
                else
                {
                    DanhSach temp = new DanhSach(value);
                    temp.next = p.next;
                    p.next = temp;
                }
            }
            return L;
        }
        static DanhSach DelHead(DanhSach L)
        {
            if (L == null)
                Console.WriteLine("Khong co gi de xoa");
            else L = L.next;
            return L;
        }

        static DanhSach DelTail(DanhSach L)
        {
            DanhSach p = L;
            while (p.next.next != null)
            {
                p = p.next;
            }
            p.next = p.next.next;
            return L;
        }

        static DanhSach DelAt(DanhSach L, int pos)
        {
            if (pos == 0 || L == null)
            {
                L = DelHead(L);
            }
            else
            {
                int k = 1;
                DanhSach p = L;
                while (p.next != null && k != pos)
                {
                    p = p.next;
                    k++;
                }
                if (k != pos)
                {
                    L = DelTail(L);
                }
                else
                {
                    p.next = p.next.next;
                }
            }
            return L;
        }
        static DanhSach reverseList(DanhSach L)
        {
            if (L == null)
                return L;
            DanhSach current = null;
            DanhSach previous = null;
            while (L != null)
            {
                current = L;
                L = L.next;
                current.next = previous;
                previous = current;
            }
            L = current;
            return L;
        }
        static void Menu()
        {
            Console.WriteLine("Chuong trinh danh sach lien ket");
            Console.WriteLine("1. Nhap phan tu vao danh sach");
            Console.WriteLine("2. Dem so phan tu trong danh sach");
            Console.WriteLine("3. Tim phan tu trong danh sach");
            Console.WriteLine("4. Them phan tu vao sau mot nut");
            Console.WriteLine("5. Xoa phan tu dung truoc mot nut");
            Console.WriteLine("6. Dao nguoc danh sach da cho");
            Console.WriteLine("7. Thoat chuong trinh");
        }
        static void Chon()
        {
            DanhSach L = null;
            int chon;
            do
            {
                Console.Write("Ban chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Boolean c = true;
                        do
                        {
                            DanhSach p = new DanhSach();
                            if (c = NhapPhanTu(p)) L = ThemPhanTu(L, p);
                        }
                        while (c);
                        break;
                    case 2:
                        int dem = DemDanhSach(L);
                        Console.WriteLine($"So phan tu trong danh sach: {dem}");
                        break;
                    case 3:
                        Console.Write("Nhap phan tu can tim: ");
                        int value = int.Parse(Console.ReadLine());
                        int pos = TimPhanTu(L, value);
                        if (pos < DemDanhSach(L)) Console.WriteLine($"Phan tu can tim o vi tri: {pos}");
                        else Console.WriteLine("Khong tim thay");
                        break;
                    case 4:
                        Console.Write("Nhap phan tu can them: ");
                        int PhanTu = int.Parse(Console.ReadLine());
                        Console.Write("Nhap vi tri can them sau: ");
                        int ViTriSau = int.Parse(Console.ReadLine());
                        L = AddAt(L, PhanTu, ViTriSau + 1);
                        InDanhSach(L);
                        break;
                    case 5:
                        Console.Write("Nhap vi tri can xoa truoc: ");
                        int ViTriTruoc = int.Parse(Console.ReadLine());
                        L = DelAt(L, ViTriTruoc - 1);
                        InDanhSach(L);
                        break;
                    case 6:
                        L = reverseList(L);
                        InDanhSach(L);
                        break;
                }
            }
            while (chon != 7);
        }
        static void Main(string[] args)
        {
            Menu();
            Chon();
        }
    }
}