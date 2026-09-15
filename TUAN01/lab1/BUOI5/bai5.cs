using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI5
{
    class bai5
    {
        public static void xuly()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("THUC DON");
                Console.WriteLine("1. Tinh dien tich tam giac");
                Console.WriteLine("2. Tinh dien tich hinh chu nhat");
                Console.WriteLine("3. Tinh dien tich hinh tron");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Moi ban chon chuc nang [1, 2, 3, 4]");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------");
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ban moi vua chon chuc nang tinh dien tich hinh tam giac");
                        Console.WriteLine("Ban nhan phim bat ky de tiep tuc ...");
                        break;
                    case 2:
                        Console.WriteLine("Ban moi vua chon chuc nang tinh dien tich hinh chu nhat");
                        Console.WriteLine("Ban nhan phim bat ky de tiep tuc ...");
                        break;
                    case 3:
                        Console.WriteLine("Ban moi vua chon chuc nang tinh dien tich hinh tron");
                        Console.WriteLine("Ban nhan phim bat ky de tiep tuc ...");
                        break;
                    case 4:
                        Console.WriteLine("ket thuc");
                        Console.WriteLine("Ban nhan phim bat ky de tiep tuc ...");
                        break;
                    default:
                        Console.WriteLine("lua chon khong hop le");
                        break;
                }
                if (choice != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("nhan Enter de quay lai menu");
                    Console.ReadLine();

                }

            } while (choice != 0);
        }
    }
}
