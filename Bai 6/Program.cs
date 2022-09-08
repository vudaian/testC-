using System;
namespace bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine(" ____________________");
            Console.WriteLine("|--- Tim min, max ---|");
            Console.WriteLine("|---   1: 2 so    ---|");
            Console.WriteLine("|---   2: 3 so    ---|");
            Console.WriteLine("|---   3: 4 so    ---|");
            Console.WriteLine("|____________________|");

            Console.Write("Nhap lua chon: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch(n) {
                case 1: 
                    tow_number();
                    break;
                case 2:
                    three_number();
                    break;
                case 3:
                    four_number();
                    break;
                default: 
                    Console.WriteLine("Lua chon khong chinh xac!");
                    break;
            }
        }
        public static void tow_number() {
            int a, b;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(a > b) Console.WriteLine($"{a} la so lon nhat, {b} la so nho nhat");
            else Console.WriteLine($"{b} la so lon nhat, {a} la so nho nhat");
        }

        public static void three_number() {
            int a, b, c;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine()); 
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }

            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }

            Console.WriteLine($"So lon nhat la: {max}");
            Console.WriteLine($"So nho nhat la: {min}");
        }

        public static void four_number() {
            int a, b, c, d;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Nhap d: ");
            d = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (max < d)
            {
                max = d;
            }

            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            if (min > d)
            {
                min = d;
            }

            Console.WriteLine($"So lon nhat la: {max}");
            Console.WriteLine($"So nho nhat la: {min}");
        }
    }
}