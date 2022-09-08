using System;
namespace bai_13
{
    class Program
    {
        static void Main(string[] args) {
            int s, p, h;
            Console.Write("Nhap giay: ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap phut: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gio: ");
            h = Convert.ToInt32(Console.ReadLine());
            if (h < 0 || h > 24) Console.WriteLine($"{s}/{p}/{h} khong hop le");
            else {
                if (p < 0 || p > 60) Console.WriteLine($"{s}/{p}/{h} khong hop le");
                else {
                    if (s < 0 || s > 60) Console.WriteLine($"{s}/{p}/{h} khong hop le");
                    else {
                        Console.WriteLine($"{s}/{p}/{h} hop le");
                    }
                }
            }
        }
    }
}