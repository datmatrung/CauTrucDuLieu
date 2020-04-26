using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
	class Program
	{
        static void mergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }

        static void merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            /* Số lượng phần tử của các mảng tạm */
            int n1 = m - l + 1;
            int n2 = r - m;
            /* Tạo các mảng tạm */
            int[] L = new int[n1];
            int[] R = new int[n2];
            /* Copy dữ liệu sang các mảng tạm */
            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];
            /* Gộp hai mảng tạm vào mảng arr*/
            i = 0; j = 0; k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            /* Copy các phần tử còn lại của mảng L vào arr nếu có */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            /* Copy các phần tử còn lại của mảng R vào arr nếu có */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        static void Main(string[] args)
        {
            int[] A = { 7, 8, 3, 5, 4, 2, 8, 6 };
            mergeSort(A, 0, A.Length - 1);
            Console.ReadLine();
        }
    }
}
