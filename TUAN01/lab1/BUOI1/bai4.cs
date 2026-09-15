using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI1
{
    class bai4
    {
        public static void xuly()
        {

            int t,h,m,s;
            Console.Write("Nhap tong so giay: "); t = int.Parse(Console.ReadLine());
            h = t / 3600;
            m = (t % 3600) / 60;
            s = t % 60;
            Console.WriteLine($"Vay {t} co dang {h}:{m}:{s}");
        }
    }
}
