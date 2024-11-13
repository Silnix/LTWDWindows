using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot nam duong lich: ");
            int year = int.Parse(Console.ReadLine());

            bool LaNamNhuan = false;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        LaNamNhuan = true;
                    }
                }
                else
                {
                    LaNamNhuan = true;
                }
            }

            if (LaNamNhuan)
            {
                Console.WriteLine($"{year} la nam nhuan.");
            }
            else
            {
                Console.WriteLine($"{year} khong phai la nam nhuan.");
            }
            Console.ReadLine();
        }
    }
}
