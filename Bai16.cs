using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào mức lương mỗi ngày
            Console.Write("Nhap muc luong moi ngay (dong): ");
            double luongMoiNgay = Convert.ToDouble(Console.ReadLine());

            // Nhập vào số ngày làm việc
            Console.Write("Nhap so ngay lam viec: ");
            int soNgayLamViec = Convert.ToInt32(Console.ReadLine());

            // Nhập vào số giờ làm việc tăng ca
            Console.Write("Nhap so gio lam viec tang ca: ");
            int soGioTangCa = Convert.ToInt32(Console.ReadLine());

            // Nhập vào số ngày đi trễ
            Console.Write("Nhap so ngay di tre: ");
            int soNgayDiTre = Convert.ToInt32(Console.ReadLine());

            // Tính tiền thưởng
            double tienThuong = 0;

            // Tiền thưởng cho giờ làm việc tăng ca
            tienThuong += soGioTangCa * 10000;

            // Tiền thưởng cho ngày làm việc từ ngày thứ 25
            if (soNgayLamViec > 24)
            {
                tienThuong += (soNgayLamViec - 24) * 15000;
            }

            // Tính tiền phạt
            double tienPhat = soNgayDiTre * 20000;

            // Tính tiền lương
            double tienLuong = (luongMoiNgay * soNgayLamViec) + tienThuong - tienPhat;

            // In ra tiền lương của công nhân
            Console.WriteLine("Tien luong cua cong nhan la: " + tienLuong + " dong");
            Console.ReadLine();
        }
    }
}
