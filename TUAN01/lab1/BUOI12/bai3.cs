using System;

namespace BUOI12
{
    class bai3
    {
        public static void xuly()
        {
            Console.WriteLine("===== BAI 3: MA TRAN TOAN LE =====");

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

            bool toanLe = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        toanLe = false;
                        break;
                    }
                }

                if (!toanLe)
                {
                    break;
                }
            }

            if (toanLe)
            {
                Console.WriteLine("Ma tran toan le.");
            }
            else
            {
                Console.WriteLine("Ma tran khong toan le.");
            }

            Console.WriteLine();
        }
    }
}