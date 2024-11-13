using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Cac uoc so cua n: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine("" + i);
            }

            Console.ReadLine();
        }
    }
}
