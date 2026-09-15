using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI1
{
    class bai3
    {
        public static void xuly()
        {
            int h, m, s;
            int tonggiay;
            Console.Write("Nhap gio: "); h = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: "); m = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: "); s = int.Parse(Console.ReadLine());
            tonggiay = h * 3600 + m * 60 + s;
            Console.WriteLine($"Tong so giay cua {h}:{m}:{s} là: {tonggiay}");
        }
    }
}
