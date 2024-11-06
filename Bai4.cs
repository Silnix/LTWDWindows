using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao gio thu nhat (dinh dang hh:mm): ");
            TimeSpan time1 = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Nhap vao gio thu hai (dinh dang hh:mm): ");
            TimeSpan time2 = TimeSpan.Parse(Console.ReadLine());

            TimeSpan sum = time1 + time2;
            TimeSpan difference = time1 - time2;

            Console.WriteLine($"Tong hai gio la: {sum}");
            Console.WriteLine($"Hieu hai gio la: {difference}");

            Console.ReadLine();
        }
    }
}
