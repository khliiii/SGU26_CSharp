using System;

namespace BUOI12
{
    class bai2
    {
        public static void xuly()
        {
            Console.WriteLine("===== BAI 2: DEM SO TREN BIEN =====");

            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine()!);

            double[,] a = new double[n, m];

            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine()!);
                }
            }

            int demDuong = 0;
            int demAm = 0;
            int demKhong = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Kiem tra phan tu co nam tren bien hay khong
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    {
                        if (a[i, j] > 0)
                        {
                            demDuong++;
                        }
                        else if (a[i, j] < 0)
                        {
                            demAm++;
                        }
                        else
                        {
                            demKhong++;
                        }
                    }
                }
            }

            Console.WriteLine(
                "Tren duong bien co " +
                demDuong + " so duong, " +
                demAm + " so am va " +
                demKhong + " so khong.");

            Console.WriteLine();
        }
    }
}