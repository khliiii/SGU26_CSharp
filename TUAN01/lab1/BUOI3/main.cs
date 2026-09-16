using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== CHUONG TRINH BUOI 3 =====");
        Console.WriteLine("1. Bai 1 - Tim max min");
        Console.WriteLine("2. Bai 2 - Tinh gia tri ham so");
        Console.WriteLine("3. Bai 3 - Phuong trinh bac 2");
        Console.WriteLine("4. Bai 4 - Thang tieng Anh");

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