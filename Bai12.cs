using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào số Kwh tiêu thụ điện
            Console.Write("Nhap vao so Kwh tieu thu dien: ");
            double kWh = Convert.ToDouble(Console.ReadLine());

            // Tính tiền điện
            double tienDien = 0;

            if (kWh <= 100)
            {
                tienDien = kWh * 600;
            }
            else if (kWh <= 150)
            {
                tienDien = 100 * 600 + (kWh - 100) * 700;
            }
            else if (kWh <= 200)
            {
                tienDien = 100 * 600 + 50 * 700 + (kWh - 150) * 900;
            }
            else
            {
                tienDien = 100 * 600 + 50 * 700 + 50 * 900 + (kWh - 200) * 1100;
            }

            // Hiển thị kết quả
            Console.WriteLine("Tien dien phai tra: {0} dong", tienDien);
            Console.ReadLine();
        }
    }
}
