using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI11
{
     class bai4
    {
        public static void xuly(string[] args)
        {
            Console.WriteLine("Bai 4: Dao nguoc mang");
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int[] a = new int[n];
            Console.WriteLine("Nhap cac phan tu cua day:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            Console.WriteLine("* Mang truoc khi dao:");
            Console.WriteLine("Day so co {0} phan tu: {1}", n, string.Join(" ", a));
            for (int i = 0; i < n / 2; i++)
            {
                int temp = a[i];
                a[i] = a[n - 1 - i];
                a[n - 1 - i] = temp;
            }
            Console.WriteLine("* Mang sau khi dao:");
            Console.WriteLine("Day so co {0} phan tu: {1}", n, string.Join(" ", a));

            Console.ReadKey();
        }
    }
}