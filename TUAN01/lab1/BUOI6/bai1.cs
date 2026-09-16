using System;

class Bai1
{
    public static void Run()
    {
        double a, b, c, d, e;

        Console.Write("Moi ban nhap 5 so a, b, c, d, e: ");
        string[] input = Console.ReadLine().Split();

        a = double.Parse(input[0]);
        b = double.Parse(input[1]);
        c = double.Parse(input[2]);
        d = double.Parse(input[3]);
        e = double.Parse(input[4]);

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

        Console.WriteLine($"Gia tri lon nhat cua {a}, {b}, {c}, {d}, {e} la {max}.");
        Console.WriteLine($"Gia tri nho nhat cua {a}, {b}, {c}, {d}, {e} la {min}.");
    }
}