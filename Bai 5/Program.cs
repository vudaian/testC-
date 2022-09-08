using System;
namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap e: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap f: ");
            int f = Convert.ToInt32(Console.ReadLine());
            float x = (float)c/(a+b);
            float y = (float)(f/e - d * c / (e * (a + b)));
            Console.Write("x = " + x);
            Console.WriteLine("");
            Console.Write("y = " + y);
        }
    }
}