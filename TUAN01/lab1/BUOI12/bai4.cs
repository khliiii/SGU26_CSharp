using System;

namespace BUOI12
{
    class bai4
    {
        public static void xuly()
        {
            Console.WriteLine("===== BAI 4: LIET KE DONG TANG DAN =====");

            // Nhap kich thuoc ma tran
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine()!);

            // Khai bao ma tran
            int[,] a = new int[n, m];

            // Nhap ma tran
            Console.WriteLine("Nhap ma tran A:");

            for (int i = 0; i < n; i++)
            {
                string[] dong = Console.ReadLine()!
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(dong[j]);
                }
            }

            Console.Write("Cac dong tao thanh day tang: ");

            bool coDong = false;

            // Xet tung dong
            for (int i = 0; i < n; i++)
            {
                bool tangDan = true;

                // Kiem tra cac phan tu trong dong
                for (int j = 0; j < m - 1; j++)
                {
                    if (a[i, j] >= a[i, j + 1])
                    {
                        tangDan = false;
                        break;
                    }
                }

                // Neu dong tang dan
                if (tangDan)
                {
                    Console.Write(i + " ");
                    coDong = true;
                }
            }

            if (!coDong)
            {
                Console.Write("Khong co");
            }

            Console.WriteLine();
        }
    }
}