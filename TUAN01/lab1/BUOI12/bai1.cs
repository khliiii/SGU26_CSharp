using System;

namespace BUOI12
{
    class bai1
    {
        public static void xuly()
        {
            Console.WriteLine("===== BAI 1: TONG CAC SO CHAN, LE =====");

            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine()!);

            int[,] a = new int[n, m];

            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            int tongChan = 0;
            int tongLe = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        tongChan += a[i, j];
                    }
                    else
                    {
                        tongLe += a[i, j];
                    }
                }
            }

            Console.WriteLine("Tong cac so chan la: " + tongChan);
            Console.WriteLine("Tong cac so le la: " + tongLe);

            Console.WriteLine();
        }
    }
}