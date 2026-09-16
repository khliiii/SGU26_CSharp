using System;

class Bai1
{
    public static void Run()
    {
        Console.Write("Nhap 5 so a, b, c, d, e: ");
        string[] input = Console.ReadLine().Split();

        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);
        double d = double.Parse(input[3]);
        double e = double.Parse(input[4]);

        double max = a;
        double min = a;

        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;
        if (e > max) max = e;

        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;
        if (e < min) min = e;

        Console.WriteLine($"So lon nhat = {max}");
        Console.WriteLine($"So nho nhat = {min}");
    }
}