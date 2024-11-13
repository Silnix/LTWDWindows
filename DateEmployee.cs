using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("", "", null, null);
            employee.NhapNhanVien();

            employee.XuatNhanVien();
            Console.ReadLine();
        }
    }
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day = 1, int month = 1, int year = 1900)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void XuatNgayThangNam()
        {
            Console.WriteLine($"{day}/{month}/{year}");
        }

        public bool KiemTraHopLe()
        {
            if (month < 1 || month > 12) return false;
            if (day < 1 || day > 31) return false;

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 30) return false;
            }
            else if (month == 2)
            {
                if (LaNamNhuan(year))
                {
                    if (day > 29) return false;
                }
                else
                {
                    if (day > 28) return false;
                }
            }
            return true;
        }

        private bool LaNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public void NhapNgayThangNam()
        {
            Console.Write("Nhap ngay: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());

            while (!KiemTraHopLe())
            {
                Console.WriteLine("Ngay thang nam khong hop le, vui long nhap lai:");
                Console.Write("Nhap ngay: ");
                day = int.Parse(Console.ReadLine());

                Console.Write("Nhap thang: ");
                month = int.Parse(Console.ReadLine());

                Console.Write("Nhap nam: ");
                year = int.Parse(Console.ReadLine());
            }
        }
    }

    public class Employee
    {
        private string lastName;
        private string firstName;
        private Date birthDate;
        private Date hireDate;

        public Employee(string lastName, string firstName, Date birthDate, Date hireDate)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.birthDate = birthDate;
            this.hireDate = hireDate;
        }

        public void XuatNhanVien()
        {
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine($"Ho va ten: {lastName} {firstName}");
            Console.Write("Ngay sinh: ");
            birthDate.XuatNgayThangNam();
            Console.Write("Ngay vao lam: ");
            hireDate.XuatNgayThangNam();
        }

        public void NhapNhanVien()
        {
            Console.Write("Nhap ho: ");
            lastName = Console.ReadLine();

            Console.Write("Nhap ten: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Hay nhap ngay sinh:");
            birthDate = new Date();
            birthDate.NhapNgayThangNam();

            Console.WriteLine("Hay nhap ngay vao lam:");
            hireDate = new Date();
            hireDate.NhapNgayThangNam();
        }
    }
}