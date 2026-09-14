using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class bai1
    {
        public static void chay()
        {
            int a, b;
            int tong;

            Console.Write("Nhap a, b: ");
            string[] tam = Console.ReadLine().Split();

            a = int.Parse(tam[0]);
            b = int.Parse(tam[1]);

            tong = b * (b + 1) / 2 - (a - 1) * a / 2;
            Console.WriteLine("tong cua cac so trong doan: ", a, b, tong);
        }
    }
}
