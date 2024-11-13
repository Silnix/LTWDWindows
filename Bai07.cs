using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen duong thu hai: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cac uoc cua {num1} la:");
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Cac uoc cua {num2} la:");
            for (int i = 1; i <= num2; i++)
            {
                if (num2 % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Cac uoc chung cua {num1} va {num2} la:");
            int min = Math.Min(num1, num2);
            for (int i = 1; i <= min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
