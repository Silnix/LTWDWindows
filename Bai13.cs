using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap vao mot so
            Console.Write("Nhap vao mot so: ");
            string input = Console.ReadLine();

            // Chuyen doi chuoi thanh so
            double number;
            bool isValid = double.TryParse(input, out number);

            // Kiem tra so
            if (isValid)
            {
                if (number > 0)
                {
                    Console.WriteLine("So {0} la so duong.", number);
                }
                else if (number < 0)
                {
                    Console.WriteLine("So {0} la so am.", number);
                }
                else
                {
                    Console.WriteLine("So {0} la so 0.", number);
                }
            }
            else
            {
                Console.WriteLine("Gia tri nhap vao khong hop le.");
            }
            Console.ReadLine();
        }
    }
}
