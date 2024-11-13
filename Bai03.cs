using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so nguyen duong: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("So vua nhap khong phai la so nguyen duong.");
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} là so chan.");
                }
                else
                {
                    Console.WriteLine($"{number} là so le.");
                }
            }
            Console.ReadLine();
        }
    }
}
