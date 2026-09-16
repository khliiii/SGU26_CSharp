using System;

class Bai4
{
    public static void Run()
    {
        Console.Write("Moi ban nhap vao thang: ");
        int thang = int.Parse(Console.ReadLine());

        switch (thang)
        {
            case 1:
                Console.WriteLine("Tieng anh cua thang 1 la January.");
                break;

            case 2:
                Console.WriteLine("Tieng anh cua thang 2 la February.");
                break;

            case 3:
                Console.WriteLine("Tieng anh cua thang 3 la March.");
                break;

            case 4:
                Console.WriteLine("Tieng anh cua thang 4 la April.");
                break;

            case 5:
                Console.WriteLine("Tieng anh cua thang 5 la May.");
                break;

            case 6:
                Console.WriteLine("Tieng anh cua thang 6 la June.");
                break;

            case 7:
                Console.WriteLine("Tieng anh cua thang 7 la July.");
                break;

            case 8:
                Console.WriteLine("Tieng anh cua thang 8 la August.");
                break;

            case 9:
                Console.WriteLine("Tieng anh cua thang 9 la September.");
                break;

            case 10:
                Console.WriteLine("Tieng anh cua thang 10 la October.");
                break;

            case 11:
                Console.WriteLine("Tieng anh cua thang 11 la November.");
                break;

            case 12:
                Console.WriteLine("Tieng anh cua thang 12 la December.");
                break;

            default:
                Console.WriteLine("Thang khong hop le!");
                break;
        }
    }
}