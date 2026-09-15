using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI11
{
    class bai3
    {
        public static void xuly(string[] args)
        {
            Console.WriteLine("Bai 3: Them chan le");
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int[] a = new int[n];
            Console.WriteLine("Nhap cac phan tu cua day:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            Console.WriteLine("* Mang truoc khi them:");
            Console.WriteLine("Day so co {0} phan tu: {1}", n, string.Join(" ", a));
            List<int> ketQua = new List<int>();
            for (int i = 0; i < n - 1; i++)
            {
                ketQua.Add(a[i]);
                if (a[i] % 2 == 0 && a[i + 1] % 2 == 0)
                {
                    ketQua.Add(a[i] + 1);
                }
            }
            if (n > 0)
            {
                ketQua.Add(a[n - 1]);
            }
            Console.WriteLine("* Mang sau khi them:");
            Console.WriteLine("Day so co {0} phan tu: {1}", ketQua.Count, string.Join(" ", ketQua));

            Console.ReadKey();
        }
    }
}