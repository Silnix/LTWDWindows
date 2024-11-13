using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 2: Giai phuong trinh bac 2
            Console.WriteLine("Bai 2: ");
            Double a, b, c, delta;
            bool co2 = true;
            while (co2)
            {
                Console.WriteLine("\nNhap cac he so phuong trinh a, b, c voi a*x^2 + b*x + c = 0\n");
                Console.Write("a = ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = Double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = Double.Parse(Console.ReadLine());

                if (a != 0)
                {
                    delta = b * b - 4 * a * c;

                    if (delta < 0)
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                    else
                        if (delta == 0)
                    {
                        Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + (-b / (2 * a)));
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1, x2: ");
                        Console.WriteLine("x1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)));
                        Console.WriteLine("x2 = " + ((-b - Math.Sqrt(delta)) / (2 * a)));
                    }
                }
                else
                {
                    Console.WriteLine("Khong co dang phuong trinh bac 2");
                }

                Console.Write("\nBan co muon tinh toan tiep Bai 2 hay khong (1=Yes/0=No):  ");
                int tt2 = int.Parse(Console.ReadLine());
                if (tt2 == 0)
                    co2 = false;
            }

            //Ket thuc:
            Console.Write("\nChao Tam Biet!!!!  ");
            Console.ReadLine();
        }
    }
}
