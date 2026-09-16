using System;

class Bai3
{
    public static void Run()
    {
        Console.Write("Moi ban nhap he so a, b, c: ");

        string[] input = Console.ReadLine().Split();

        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        // Trường hợp a = 0
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phuong trinh co 1 nghiem x = {x:F2}");
            }

            return;
        }

        // Tính delta
        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);

            Console.WriteLine($"Phuong trinh co nghiem kep x = {x:F2}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"Phuong trinh co 2 nghiem, x1 = {x1:F2}, x2 = {x2:F2}");
        }
    }
}