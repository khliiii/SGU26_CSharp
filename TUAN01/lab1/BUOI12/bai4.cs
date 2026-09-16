using System;

namespace BUOI12
{
    class bai4
    {
        public static void xuly()
        {
            Console.WriteLine("===== BAI 4: DONG TOAN CHAN =====");

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

            bool coDong = false;

            Console.Write("Cac dong toan chan: ");

            for (int i = 0; i < n; i++)
            {
                bool toanChan = true;

                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 != 0)
                    {
                        toanChan = false;
                        break;
                    }
                }

                if (toanChan)
                {
                    Console.Write(i + " ");
                    coDong = true;
                }
            }

            if (!coDong)
            {
                Console.Write("Khong co dong nao.");
            }

            Console.WriteLine();
        }
    }
}