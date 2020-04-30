using System;
namespace ConsoleApp16
{
    public class Program
    {
        public static void RadixSort(int[] arr, int n)
        {
            int[] output = new int[n];
            int[] count = new int[10];
            int max = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > max) max = arr[i];
            int exp = 1;
            while (max / exp > 0)
            {
                // Khởi tạo bộ đếm của các thùng chứa từ 0 đến 9
                for (int i = 0; i < 10; i++)
                    count[i] = 0;
                // Sắp xếp dãy số vào trong thùng và tăng bộ đếm của từng thùng
                for (int i = 0; i < n; i++)
                    count[(arr[i] / exp) % 10]++;
                // Kết nối các phần tử tạo thành dãy các chỉ số đã sắp xếp
                for (int i = 1; i < 10; i++)
                    count[i] += count[i - 1];
                // Xây dựng mảng output dựa trên dãy các chỉ số đã sắp xếp
                for (int i = n - 1; i >= 0; i--)
                {
                    output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                    count[(arr[i] / exp) % 10]--;
                }
                // Copy mảng output vào mảng arr
                for (int i = 0; i < n; i++)
                    arr[i] = output[i];
                exp *= 10;
            }
        }
        public static void Main()
        {
            int[] arr = { 27, 25, 75, 77, 12, 24, 32, 70 };
            RadixSort(arr, arr.Length);
        }
    }
}
