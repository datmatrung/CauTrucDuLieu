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
            A[n - 1] = x;
            int i = 0;
            while (x != A[i])
                i++;
            return i;
        }
        static int TimKiemNhiPhan(int[] A, int n, int x)
        {
            int L = 0;
            int R = n - 1;
            int M;
            do
            {
                M = (L + R) / 2;
                if (x < A[M]) R = M - 1;
                else if (x > A[M]) L = M + 1;
                else return M;
            }
            while (L > R);
            return M;
        }
        static void Main(string[] args)
        {
            int[] A;
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            A = NhapMang(n);
            Console.Write("Nhap phan tu can tim: ");
            int x = int.Parse(Console.ReadLine());
            int i = TimKiemTuanTuVetCan(A, n, x);
            //int i = TimKiemTuanTuLinhCanh(A, n, x);
            //int i = TimKiemNhiPhan(A, n, x);
            Console.Write($"{x} vi tri {i}");
            Console.ReadLine();
        }
