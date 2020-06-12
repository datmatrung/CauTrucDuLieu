class Program
{
    static void SelectionSort(int[] A)
    {
        int n = A.Length;
        for (int i = 0; i < n; i++)
        {
            int min = i;
            for (int j = i; j < n; j++)
                if (A[min] > A[j]) min = j;
            int temp = A[min];
            A[min] = A[i];
            A[i] = temp;
        }    
    }
    static void Main()
    {
        int[] A = { 2, 7, 13, 50, 24, 16 };
        SelectionSort(A);
    }
}
