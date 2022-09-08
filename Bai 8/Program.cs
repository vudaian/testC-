using System;
namespace bai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, temp;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine()); 

            if(a > b) {
                temp = a;
                a = b;
                b = temp;
            }
            if(a > c) {
                temp = a;
                a = c;
                c = temp;
            }
            if(b > c) {
                temp = b;
                b = c;
                c = temp;
            }
            Console.WriteLine($"Sap xep theo thu tu tang dan la: {a}, {b}, {c}");
        }
    }
}