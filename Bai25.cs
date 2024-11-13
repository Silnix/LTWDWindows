using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine(n + " khong phai la so nguyen to.");
            }
            else
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(n + " la so nguyen to.");
                }
                else
                {
                    Console.WriteLine(n + " khong phai la so nguyen to.");
                }
                Console.ReadLine();
            }
        }
    }
}
