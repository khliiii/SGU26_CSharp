using System;

class Bai2
{
    public static void Run()
    {
        Console.Write("Moi ban nhap so thuc x: ");
        double x = double.Parse(Console.ReadLine());

        double f1;
        double f2;

        // Tinh f1(x)
        if (x <= 0)
        {
            f1 = 0;
        }
        else if (x <= 1)
        {
            f1 = x;
        }
        else
        {
            f1 = Math.Pow(x, 4);
        }

        // Tinh f2(x)
        if (x <= 2)
        {
            f2 = x * x + 4 * x + 5;
        }
        else
        {
            f2 = 1 / (x * x + 4 * x + 5);
        }

        Console.WriteLine($"f1({x}) = {f1}");
        Console.WriteLine($"f2({x}) = {f2}");
    }
}