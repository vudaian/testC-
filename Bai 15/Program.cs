using System;
namespace bai_15
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Nhap so km di duoc: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1) Console.WriteLine($"So tien phai tra sau khi di {n}km la: 13000 VND");
            else if (n > 1 && n < 30) Console.WriteLine($"So tien phai tra sau khi di {n}km la: {13000 + (n - 1) * 12000} VND");
            else Console.WriteLine($"So tien phai tra sau khi di {n}km la: {13000 + (n - 1 - (n - 30)) * 12000 + (n - 30) * 11000} VND");
        }
    }
}