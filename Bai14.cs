using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến
            int soNgayThue;
            char loaiPhong;
            double giaPhong = 0;
            double tongTien;

            // Nhập số ngày thuê
            Console.Write("Nhap so ngay thue: ");
            soNgayThue = int.Parse(Console.ReadLine());

            // Nhập loại phòng
            Console.Write("Nhap loai phong (A/B/C): ");
            loaiPhong = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Xác định giá phòng theo loại
            switch (loaiPhong)
            {
                case 'A':
                    giaPhong = 250000;
                    break;
                case 'B':
                    giaPhong = 200000;
                    break;
                case 'C':
                    giaPhong = 150000;
                    break;
                default:
                    Console.WriteLine("Loai phong khong hop le.");
                    return;
            }

            // Tính tổng tiền
            tongTien = soNgayThue * giaPhong;

            // Kiểm tra giảm giá
            if (soNgayThue > 10)
            {
                tongTien *= 0.9; // Giảm 10%
            }

            // Hiển thị kết quả
            Console.WriteLine("Tong tien thue phong: {0:0,0} VND", tongTien);
            Console.ReadLine();
        }
    }
}
