using System;
namespace bai_19
{
    class Program
    {
        static void Main(string[] args) {
            int count = 0;
            Console.Write("Nhap so can kiem tra: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 2) Console.WriteLine($"{n} khong la so chinh phuong!");
            else {
                for(int i = 2; i < n; i++) {
                    if(i * i == n) {
                        count++;
                    }
                }
                if(count != 0) {
                    Console.WriteLine($"{n} la so chinh phuong");
                } else Console.WriteLine($"{n} khong la so chinh phuong");
            }
        }
    }
}