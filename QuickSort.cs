using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
		static int PhanHoach(int[] A, int first, int last)
		{
			int pivot = first;
			int firstS2, firstUnknown;
			firstS2 = firstUnknown = first + 1;
			while (firstUnknown <= last)
			{
				if (A[pivot] > A[firstUnknown])
				{
					int temp = A[firstS2];
					A[firstS2] = A[firstUnknown];
					A[firstUnknown] = temp;
					firstS2++;
				}
				firstUnknown++;
			}
			int temp1 = A[pivot];
			A[pivot] = A[firstS2 - 1];
			A[firstS2 - 1] = temp1;
			return firstS2 - 1;
		}
		static void QuickSort(int[] A, int first, int last)
		{
			if (first < last)
			{
				int pivot = PhanHoach(A, first, last);
				QuickSort(A, first, pivot - 1);
				QuickSort(A, pivot + 1, last);
			}
		}
		static void Main(string[] args)
        {
			int[] A = { 4, 8, 1, 9, 5 };
			QuickSort(A, 0, A.Length - 1);
			Console.ReadLine();
		}
    }
}
