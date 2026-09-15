using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI11
{
    class bai2
    {
        public static void xuly(string[] args)
        {
            Console.WriteLine("Bai 2: Xoa cac phan tu chan trong mang");
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int[] a = new int[n];
            List<int> ketQua = new List<int>();

            Console.WriteLine("Nhap cac phan tu cua day:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine() ?? "0");
                if (a[i] % 2 != 0)
                {
                    ketQua.Add(a[i]);
                }
            }
            Console.WriteLine("* Mang truoc khi xoa:");
            Console.WriteLine("Day so co {0} phan tu: {1}", n, string.Join(" ", a));
            Console.WriteLine("* Mang sau khi xoa:");
            int nSauKhiXoa = ketQua.Count;
            Console.WriteLine("Day so co {0} phan tu: {1}", nSauKhiXoa, string.Join(" ", ketQua));

            Console.ReadKey();
        }
    }
}