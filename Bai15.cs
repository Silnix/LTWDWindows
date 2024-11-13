using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;

            // Nhap thang
            Console.Write("Nhap thang (1-12): ");
            thang = int.Parse(Console.ReadLine());

            // Nhap nam
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());

            int soNgay = 0;

            // Xac dinh so ngay trong thang
            switch (thang)
            {
                case 1: // Thang 1
                case 3: // Thang 3
                case 5: // Thang 5
                case 7: // Thang 7
                case 8: // Thang 8
                case 10: // Thang 10
                case 12: // Thang 12
                    soNgay = 31;
                    break;
                case 4: // Thang 4
                case 6: // Thang 6
                case 9: // Thang 9
                case 11: // Thang 11
                    soNgay = 30;
                    break;
                case 2: // Thang 2
                        // Kiem tra nam nhuan
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                    {
                        soNgay = 29; // Nam nhuan
                    }
                    else
                    {
                        soNgay = 28; // Nam khong nhuan
                    }
                    break;
                default:
                    Console.WriteLine("Thang khong hop le.");
                    return;
            }

            // In ra so ngay
            Console.WriteLine($"Thang {thang} nam {nam} co {soNgay} ngay.");
            Console.ReadLine();
        }
    }
}
