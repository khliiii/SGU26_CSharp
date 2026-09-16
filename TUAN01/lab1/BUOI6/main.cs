using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== BUOI 6 =====");
        Console.WriteLine("1. In hinh chu I va U");
        Console.WriteLine("2. Xu ly chu so");
        Console.WriteLine("3. Phan tich thua so nguyen to");
        Console.WriteLine("4. Kiem tra so hoan hao");

        Console.Write("Moi ban chon bai: ");
        int chon = int.Parse(Console.ReadLine());

        switch (chon)
        {
            case 1:
                Bai1.Run();
                break;

            case 2:
                Bai2.Run();
                break;

            case 3:
                Bai3.Run();
                break;

            case 4:
                Bai4.Run();
                break;

            default:
                Console.WriteLine("Khong co bai nay!");
                break;
        }

        Console.WriteLine("\nNhan Enter de thoat...");
        Console.ReadLine();
    }
}