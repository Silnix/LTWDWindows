using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap so luong nhan vien can nhap: ");
            int soLuongNhanVien = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < soLuongNhanVien; i++)
            {
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("Chon loai nhan vien can nhap thong tin:");
                Console.WriteLine("1. Nhan vien luong co dinh");
                Console.WriteLine("2. Nhan vien luong theo gio");
                Console.WriteLine("3. Nhan vien hue hong");
                Console.WriteLine("4. Nhan vien hue hong co luong co ban");
                Console.Write("Nhap lua chon (1-4): ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");

                switch (choice)
                {
                    case 1:
                        employees.Add(NhapSalariedEmployee());
                        break;
                    case 2:
                        employees.Add(NhapHourlyEmployee());
                        break;
                    case 3:
                        employees.Add(NhapCommissionEmployee());
                        break;
                    case 4:
                        employees.Add(NhapBasePlusCommissionEmployee());
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long thu lai.");
                        i--;
                        break;
                }
            }

            foreach (Employee employee in employees)
            {
                employee.Print();
                Console.WriteLine($"Thu nhap: {employee.Earnings()}");
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.ReadLine();

            }
        }
        static SalariedEmployee NhapSalariedEmployee()
        {
            Console.Write("Nhap ho: ");
            string firstName = Console.ReadLine();
            Console.Write("Nhap ten: ");
            string lastName = Console.ReadLine();
            Console.Write("Nhap so bao hiem xa hoi: ");
            string ssn = Console.ReadLine();
            Console.Write("Nhap luong co dinh hang tuan: ");
            double weeklySalary = double.Parse(Console.ReadLine());
            return new SalariedEmployee(firstName, lastName, ssn, weeklySalary);
        }

        static HourlyEmployee NhapHourlyEmployee()
        {
            Console.Write("Nhap ho: ");
            string firstName = Console.ReadLine();
            Console.Write("Nhap ten: ");
            string lastName = Console.ReadLine();
            Console.Write("Nhap so bao hiem xa hoi: ");
            string ssn = Console.ReadLine();
            Console.Write("Nhap luong theo gio: ");
            double wage = double.Parse(Console.ReadLine());
            Console.Write("Nhap so gio lam viec: ");
            double hours = double.Parse(Console.ReadLine());
            return new HourlyEmployee(firstName, lastName, ssn, wage, hours);
        }

        static CommissionEmployee NhapCommissionEmployee()
        {
            Console.Write("Nhap ho: ");
            string firstName = Console.ReadLine();
            Console.Write("Nhap ten: ");
            string lastName = Console.ReadLine();
            Console.Write("Nhap so bao hiem xa hoi: ");
            string ssn = Console.ReadLine();
            Console.Write("Nhap tong doanh so ban: ");
            double grossSales = double.Parse(Console.ReadLine());
            Console.Write("Nhap ti le hue hong (thap phan): ");
            double commissionRate = double.Parse(Console.ReadLine());
            return new CommissionEmployee(firstName, lastName, ssn, grossSales, commissionRate);
        }

        static BasePlusCommissionEmployee NhapBasePlusCommissionEmployee()
        {
            Console.Write("Nhap ho: ");
            string firstName = Console.ReadLine();
            Console.Write("Nhap ten: ");
            string lastName = Console.ReadLine();
            Console.Write("Nhap so bao hiem xa hoi: ");
            string ssn = Console.ReadLine();
            Console.Write("Nhap tong doanh so ban: ");
            double grossSales = double.Parse(Console.ReadLine());
            Console.Write("Nhap ti le hue hong (thap phan): ");
            double commissionRate = double.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban hang tuan: ");
            double baseSalary = double.Parse(Console.ReadLine());
            return new BasePlusCommissionEmployee(firstName, lastName, ssn, grossSales, commissionRate, baseSalary);
        }
    }
    abstract class Employee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;

        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value; }
        }

        public abstract double Earnings(); // Phương thức thuần ảo

        public virtual void Print()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Nhan vien: {firstName} {lastName}\nSo bao hiem xa hoi: {socialSecurityNumber}");
        }
    }

    class SalariedEmployee : Employee
    {
        private double weeklySalary;

        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, double weeklySalary = 0)
            : base(firstName, lastName, socialSecurityNumber)
        {
            this.weeklySalary = weeklySalary;
        }

        public double WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        public override double Earnings()
        {
            return weeklySalary;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Luong co dinh hang tuan: {weeklySalary}");
        }
    }

    class HourlyEmployee : Employee
    {
        private double wage;
        private double hours;

        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, double wage = 0, double hours = 0)
            : base(firstName, lastName, socialSecurityNumber)
        {
            this.wage = wage;
            this.hours = hours;
        }

        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }

        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public override double Earnings()
        {
            if (hours <= 40)
            {
                return wage * hours;
            }
            else
            {
                return (40 * wage) + ((hours - 40) * wage * 1.5);
            }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Luong theo gio: {wage}, So gio lam viec: {hours}");
        }
    }

    class CommissionEmployee : Employee
    {
        private double grossSales;
        private double commissionRate;

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales = 0, double commissionRate = 0)
            : base(firstName, lastName, socialSecurityNumber)
        {
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
        }

        public double GrossSales
        {
            get { return grossSales; }
            set { grossSales = value; }
        }

        public double CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }

        public override double Earnings()
        {
            return grossSales * commissionRate;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Tong doanh so ban: {grossSales}, Ti le hue hong: {commissionRate}");
        }
    }

    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double baseSalary;

        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales = 0, double commissionRate = 0, double baseSalary = 0)
            : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            this.baseSalary = baseSalary;
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public override double Earnings()
        {
            return baseSalary + base.Earnings();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Luong co ban: {baseSalary}");
        }
    }
}