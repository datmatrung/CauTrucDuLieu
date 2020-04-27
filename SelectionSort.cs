using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
	class Program
	{
        static void selectionSort(int[] arr, int n)
        {
            int i, j, min_index;
            // Di chuyển ranh giới của mảng đã sắp xếp và chưa sắp xếp
            for (i = 0; i < n - 1; i++)
            {
                // Tìm phần tử nhỏ nhất trong mảng chưa sắp xếp
                min_index = i;
                for (j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_index])
                        min_index = j;
                // Đổi chỗ phần tử nhỏ nhất với phần tử đầu tiên
                int temp = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] A = { 7, 8, 3, 5, 4, 2, 9, 6 };
            selectionSort(A, A.Length);
            Console.ReadLine();
        }
    }
}
