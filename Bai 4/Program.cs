﻿using System;
namespace Bai_4
{
    class Program
    {
        static void Main(string[] arge)
        {
            int x1, x2, x3, x4;
            Console.Write("Nhap x cua f1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap x cua f2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap x cua f3: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap x cua f4: ");
            x4 = Convert.ToInt32(Console.ReadLine());
            f1(x1);
            f2(x2);
            f3(x3);
            f4(x4);
        }
        public static void f1(int x)
        {
            if (x < 0) Console.Write("Khong thoa mai dien kien");
            else Console.WriteLine($"Ket qua: {3 * x + Math.Sqrt(x)}");
        }
        public static void f2(int x)
        {
            if (x <= 0) Console.Write("Khong thoa mai dien kien");
            else Console.WriteLine($"Ket qua: {Math.Pow(2.7183, x) + 4}");
        }
        public static void f3(int x)
        {
            if (x < 1 && x > -1) Console.Write("Khong thoa mai dien kien");
            else Console.WriteLine($"Ket qua: {3 * x + 5}");
        }
        public static void f4(int x)
        {
            if (x <= -1) Console.Write("Khong thoa mai dien kien");
            else Console.WriteLine($"Ket qua: {x * x + 2 * x - 1}");
        }
    }
}