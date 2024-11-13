using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Int32.Parse(Console.ReadLine());

            int i = 1;
            int Dem = 0;

            while (i <= n)
            {
                if (n % i == 0)
                    ++Dem;
                ++i;
            }

            Console.WriteLine("So uoc so cua {0} la {1}", n, Dem);
            Console.ReadLine();
        }
    }
}
