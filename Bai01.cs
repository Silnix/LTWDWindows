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
            //Bai 1: Tinh tb mon
            Console.WriteLine("Bai 1: ");
            Double D_Toan, D_Ly, D_Hoa, D_TB;
            bool co = true;
            while (co)
            {
                Console.Write("Nhap Diem Toan: ");
                D_Toan = Double.Parse(Console.ReadLine());

                Console.Write("Nhap Diem Ly: ");
                D_Ly = Double.Parse(Console.ReadLine());

                Console.Write("Nhap Diem Hoa: ");
                D_Hoa = Double.Parse(Console.ReadLine());

                D_TB = (D_Toan + D_Ly + D_Hoa) / 3;

                if (D_TB >= 9)
                {
                    Console.Write("\nXep Loai SX  ");
                }
                else
                        if (D_TB >= 8)
                {
                    Console.Write("\nXep Loai Gioi  ");
                }
                else
                                if (D_TB >= 6.5)
                {
                    Console.Write("\nXep Loai Kha  ");
                }
                else
                                        if (D_TB >= 5)
                {
                    Console.Write("\nXep Loai TB  ");
                }
                else
                                                if (D_TB >= 3.5)
                {
                    Console.Write("\nXep Loai Yeu  ");
                }
                else
                    Console.Write("\nXep Loai Kem  ");

                Console.Write("\nBan co muon tinh toan tiep Bai 1 hay khong (1=Yes/0=No):  ");
                int tt = int.Parse(Console.ReadLine());
                if (tt == 0)
                    co = false;
            }
            //Ket thuc:
            Console.Write("\nChao Tam Biet!!!!  ");
            Console.ReadLine();
        }
    }
}
