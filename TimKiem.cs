using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] NhapMang(int n)
        {
            int[] A;
            A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap A[{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
        static int TimKiemTuanTuVetCan(int[] A, int n, int x)
        {
            int i = 0;
            while (i < n)
            {
                if (x != A[i]) i++;
                else return i;
            }
            return -1;
        }
        static int TimKiemTuanTuLinhCanh(int[] A, int n, int x)
        {
            int[] B = new int[n + 1];
            Array.Copy(A, B, n);
            B[n] = x;
            int i = 0;
            while (x != B[i])
                i++;
            if (i == n) i = -1;
            return i;
        }
        static int TimKiemNhiPhan(int[] A, int n, int x)
        {
            int Left = 0;
            int Right = n - 1;
            while (Left <= Right)
            {
                int Mid = (Left + Right) / 2;
                if (x == A[Mid]) return Mid;
                else if (x < A[Mid]) Right = Mid - 1;
                else Left = Mid + 1;
            }
            return -1;
        }
        static int TimKiemNhiPhanDeQuy(int[] A, int left, int right, int x)
        {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            if (A[mid] == x) return mid;
            if (x < A[mid]) return TimKiemNhiPhanDeQuy(A, left, mid - 1, x);
            return TimKiemNhiPhanDeQuy(A, mid + 1, right, x);
        }
        static void Main(string[] args)
        {
            int[] A;
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            A = NhapMang(n);
            Console.Write("Nhap phan tu can tim: ");
            int x = int.Parse(Console.ReadLine());
            //int i = TimKiemTuanTuVetCan(A, n, x);
            //int i = TimKiemTuanTuLinhCanh(A, n, x);
            //int i = TimKiemNhiPhan(A, n, x);
            int i = TimKiemNhiPhanDeQuy(A, 0, n-1, x);
            Console.Write($"{x} vi tri {i}");
            Console.ReadLine();
        }
    }
}
