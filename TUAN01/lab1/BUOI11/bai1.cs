using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI11
{
    class bai1
    {  
        
        static void nhap(ref int[] a)
        {
            int n;
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

    }
}
