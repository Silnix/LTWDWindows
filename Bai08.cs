using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 2 so nguyen can thuc hien phep toan: ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Thuc hien 1 trong nhung phep toan sau day: ");
            Console.WriteLine("*********************************************");
            Console.WriteLine("**   Bam phim 1 de thuc hien phep cong     **");
            Console.WriteLine("**   Bam phim 2 de thuc hien phep tru      **");
            Console.WriteLine("**   Bam phim 3 de thuc hien phep nhan     **");
            Console.WriteLine("**   Bam phim 4 de thuc hien phep chia     **");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Vui long bam phim de thuc hien phep toan! ");
            int key = int.Parse(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("Tong cua 2 so nguyen a va b la: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Hieu cua 2 so nguyen a va b la: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Tich cua 2 so nguyen a va b la: " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Thuong cua 2 so nguyen a va b la: " + (a / b));
                    break;
                default:
                    Console.WriteLine("Vui long chon dung phim de thuc hien lenh!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
