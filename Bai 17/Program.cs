using System;
namespace bai_17
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Nhap so can kiem tra: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= n; i++) {
                if(n % i == 0) {
                    count++;
                }
            }
            if(count == 2) {
                Console.WriteLine($"{n} la so nguyen to!");
            } else Console.WriteLine($"{n} khong la so nguyen to");
        }
    }
}