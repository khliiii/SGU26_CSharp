using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI11
{
    class bai1
    {
        public static void xuly(string[] args)
        {
            Console.WriteLine("Bai 1: Sap xep mang tang dan cac so chan va giam dan cac so le");
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int[] a = new int[n];
            List<int> chan = new List<int>();
            List<int> le = new List<int>();

            Console.WriteLine("Nhap cac phan tu cua day:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine() ?? "0");

                if (a[i] % 2 == 0)
                {
                    chan.Add(a[i]);
                }
                else
                {
                    le.Add(a[i]);
                }
            }

            Console.WriteLine("* Mang truoc khi sap xep:");
            Console.WriteLine("Day so co {0} phan tu: {1}", n, string.Join(" ", a));
            chan.Sort();
            le.Sort();
            le.Reverse();
            int[] result = new int[n];
            chan.CopyTo(result, 0);
            le.CopyTo(result, chan.Count);

            Console.WriteLine("* Mang sau khi sap xep:");
            Console.WriteLine("Day so co {0} phan tu: {1}", n, string.Join(" ", result));

            Console.ReadKey();
        }
    }
}