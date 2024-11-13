using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so thu hai: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so thu ba: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so thu tu: ");
            int num4 = int.Parse(Console.ReadLine());

            if (num1 <= 0 || num2 <= 0 || num3 <= 0 || num4 <= 0)
            {
                Console.WriteLine("Co so vua nhap khong la so nguyen duong.");
            }
            else
            {
                int max = Math.Max(Math.Max(num1, num2), Math.Max(num3, num4));
                Console.WriteLine($"So lon nhat trong 4 so vua nhap la: {max}");
            }
            Console.ReadLine();
        }
    }
}
