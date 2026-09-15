using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI5
{
    class bai2
    {
        public static void xuly()
        {
            int n, i;
            float s1;
            double s2 = 0.0;
            Console.Write("Nhap so nguyen duong n: ");
            n = int.Parse(Console.ReadLine());
            s1 = 0;
            for (i = 1; i <= n; i++)
            {
                s1 += 1.0f / i;
            }
            while (n > 0)
            {
                s2 += Math.Pow(-1.0, n + 1) * 1.0 / n;
                n = n - 1;
            }
            Console.WriteLine("Tong s1 = {0}, Tong s2 = {1}", s1, s2);
        }
    }
}