using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao canh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap vao canh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap vao canh c: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Ba canh vua nhap la cac canh cua mot tam giac.");

                if (a == b && b == c)
                {
                    Console.WriteLine("Day la tam giac deu.");
                }
                else if (a == b || b == c || a == c)
                {
                    if (IsRightTriangle(a, b, c))
                    {
                        Console.WriteLine("Day la tam giac vuong can.");
                    }
                    else
                    {
                        Console.WriteLine("Day la tam giac can.");
                    }
                }
                else if (IsRightTriangle(a, b, c))
                {
                    Console.WriteLine("Day la tam giac vuong.");
                }
                else
                {
                    Console.WriteLine("Day là tam giac thuong.");
                }
            }
            else
            {
                Console.WriteLine("Ba canh vua nhap khong lap thanh mot tam giac.");
            }
            Console.ReadLine();
        }

        static bool IsRightTriangle(double a, double b, double c)
        {
            return (a * a + b * b == c * c) ||
                   (a * a + c * c == b * b) ||
                   (b * b + c * c == a * a);
        }
    }
}
