using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI5
{
    class bai1
    {
        public static void xuly()
        {
            int n,i,s;
            Console.Write("Nhap so nguyen duong n: ");
            n = int.Parse(Console.ReadLine());
            s = 1;
            for (i = 1; i <= n; i++)
            {
                s *= i;
            }
            Console.WriteLine("Giai thua cua {0} la: {1}", n, s);
        }
    }
}
