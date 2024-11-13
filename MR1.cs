using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = InputArray(n);

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
            PrintArray(array);

            Console.WriteLine("Tong cac phan tu trong mang: " + SumArray(array));

            SortArray(array);
            Console.WriteLine("Mang sau khi sap xep: ");
            PrintArray(array);

            Console.WriteLine("Mang co chua so nguyen to: " + (ContainsPrime(array) ? "Co" : "Khong"));

            Console.Write("Nhap phan tu muon them: ");
            int elementToAdd = int.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri them phan tu: ");
            int positionToAdd = int.Parse(Console.ReadLine());
            array = InsertElement(array, elementToAdd, positionToAdd);
            Console.WriteLine("Mang sau khi them phan tu: ");
            PrintArray(array);

            Console.Write("Nhap vi tri muon xoa phan tu: ");
            int positionToDelete = int.Parse(Console.ReadLine());
            array = DeleteElement(array, positionToDelete);
            Console.WriteLine("Mang sau khi xoa phan tu: ");
            PrintArray(array);
            Console.ReadLine();
        }
        // Nhap mang voi n so nguyen
        public static int[] InputArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        // Xuat mang
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("Mang: " + string.Join(", ", array));
        }

        // Tinh va tra ve tong cac phan tu
        public static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        // Sap xep mang
        public static void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        // Kiem tra mang co so nguyen to hay khong
        public static bool ContainsPrime(int[] array)
        {
            foreach (int num in array)
            {
                if (IsPrime(num))
                {
                    return true;
                }
            }
            return false;
        }

        // Ham kiem tra so nguyen to
        private static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // Them mot phan tu vao mang tai vi tri chi dinh
        public static int[] InsertElement(int[] array, int element, int position)
        {
            List<int> list = new List<int>(array);
            list.Insert(position, element);
            return list.ToArray();
        }

        // Xoa mot phan tu trong mang tai vi tri chi dinh
        public static int[] DeleteElement(int[] array, int position)
        {
            List<int> list = new List<int>(array);
            if (position < 0 || position >= list.Count)
            {
                Console.WriteLine("Vi tri khong hop le!");
                return array;
            }
            list.RemoveAt(position);
            return list.ToArray();
        }
    }
   
}
