using System;

namespace ConsoleApp16
{
    public class Program
    {
        static void swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        
        static void heapify(int[] arr, int n, int i)
        {
            int max = i; 
            int left = 2 * i + 1; 
            int right = 2 * i + 2;
            
            if (left < n && arr[left] > arr[max])
                max = left;
            if (right < n && arr[right] > arr[max])
                max = right;
            if (max != i)
            {
                swap(arr, max, i);
                heapify(arr, n, max);
            }
        }

        static void heapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i > 0; i--)
            {
                swap(arr, 0, i);
                heapify(arr, i, 0);
            }
        }
        
        static void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            heapSort(arr, arr.Length);
            Console.ReadLine();
        }
    }
}
