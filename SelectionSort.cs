using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
	class Program
	{
        static void selectionSort(int[] A, int n)
        {
            int i = 0;
            while (i < n)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (A[j] < A[min]) min = j;
                int temp = A[min];
                A[min] = A[i];
                A[i] = temp;
                i++;
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
