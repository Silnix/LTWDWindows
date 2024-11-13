using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap trong luong buc thu (gam): ");
            double trluong = Convert.ToDouble(Console.ReadLine());

            double phi = CalculatePostageFee(trluong);

            Console.WriteLine("Cuoc phi phai tra la: {0} dong", phi);

            Console.ReadLine();
        }

        static double CalculatePostageFee(double trluong)
        {
            double phi = 0;

            if (trluong <= 100)
            {
                phi = trluong * 300;
            }
            else if (trluong <= 130)
            {
                phi = (100 * 300) + ((trluong - 100) * 200);
            }
            else
            {
                phi = (100 * 300) + (30 * 200) + ((trluong - 130) * 120);
            }

            return phi;
        }
    }
}