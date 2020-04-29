using System;

namespace ConsoleApp16
{
    public class Program
    {
        // Tìm phần tử lớn nhất trong dãy số
        public static int GetMax(int[] arr, int n)
        {
            int max = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
        // Viêt hàm sắp xếp dãy số theo cơ số exp
        public static void RadixSort(int[] arr, int n)
        {
            int max = GetMax(arr, n);
            for (int exp = 1; max / exp > 0; exp *= 10)
                CountSort(arr, n, exp);
        }

        public static void CountSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[10];
            // Khởi tạo bộ đếm của các thùng chứa từ 0 đến 9
            for (int i = 0; i < 10; i++)
                count[i] = 0;
            // Duyệt qua các phần tử và tăng bộ đếm của các thùng chứa
            for (int i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;
            // Tạo ra các chỉ số của output
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];
            // Xây dựng mảng outout dựa trên các chỉ số
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            // Gán mảng output vào dãy số arr
            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public static void Main()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            RadixSort(arr, arr.Length);
        }
    }
}
