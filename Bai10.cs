using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen duong co 2 chu so can doc: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 10 || n >= 100);
            
            string[] chuc = { " ", "muoi", "hai muoi", "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi"};
            string[] donvi = { " ", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin"};

            int hchuc = n / 10;
            int hdonvi = n % 10;

            string kq = chuc[hchuc];

            if (hdonvi != 0)
            {
                if (hchuc == 1)
                {
                    if (hdonvi == 1)
                    {
                        kq += " mot";
                    }
                    else
                    {
                        kq += " " + donvi[hdonvi];
                    }
                }
                else
                {
                    kq += " " + donvi[hdonvi];
                }
            }

            Console.WriteLine("Cach doc so nguyen " + n + " la: " + kq);
            Console.ReadLine();
        }
    }
}
