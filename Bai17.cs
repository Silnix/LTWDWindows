using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen duong co 3 chu so: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Vui long nhap mot so nguyen duong co 3 chu so.");
                return;
            }

            string result = DocSo(number);
            Console.WriteLine("Cach doc: " + result);
            Console.ReadLine();
        }

        static string DocSo(int number)
        {
            string[] units = { "", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };
            string[] tens = { "", "muoi", "hai muoi", "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi" };
            string[] hundreds = { "", "mot tram", "hai tram", "ba tram", "bon tram", "nam tram", "sau tram", "bay tram", "tam tram", "chin tram" };

            int hundred = number / 100;
            int ten = (number % 100) / 10;
            int unit = number % 10;

            string result = hundreds[hundred];

            if (ten > 0)
            {
                result += " " + tens[ten];
            }

            if (unit > 0)
            {
                if (ten > 0)
                {
                    result += " " + units[unit];
                }
                else
                {
                    result += " " + units[unit];
                }
            }

            return result.Trim();
        }
    }
}
