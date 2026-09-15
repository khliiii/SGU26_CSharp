using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI5
{
    class bai4
    {
        public static double xuly()
        {
            double a, s = 0;
            int n = 0;
            Console.Write("Nhap so thuc a: ");
            a = double.Parse(Console.ReadLine());
            while (s <= a)
            {
                s += 1.0 / (n + 1);
                n++;
            }
            return n;
        }
    }
}
