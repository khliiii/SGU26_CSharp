using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI1
{
    class bai2
    {
        public static void xuly()
        {
            float r;
            float s, p;
            Console.Write("Nhap ban kinh hinh tron: ");  
            r = float.Parse(Console.ReadLine());
            s = 3.14f * r * r;
            p = 2 * 3.14f * r;
            Console.WriteLine("Dien tich hinh tron: {0}", s);
            Console.WriteLine("Chu vi hinh tron: {0}", p);
        }
    }
}
