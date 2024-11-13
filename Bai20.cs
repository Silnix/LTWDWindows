using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong a = ");
            String valA = Console.ReadLine();
            int a = Convert.ToInt32(valA);
            Console.Write("Nhap so nguyen duong b = ");
            String valB = Console.ReadLine();
            int b = Convert.ToInt32(valB);
            // tinh USCLN cua a và b
            Console.Write("USCLN cua {0} va {1} la: {2} \n", a, b, USCLN(a, b));
            Console.ReadLine();
        }
        static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
    }
}
