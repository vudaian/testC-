using System;
namespace EX_8
{
    class Program
    {
        static void Main(string[] args) {
            int n = 2, sum = 0;
            Console.Write("Danh sach so hoan hao nho hon 1000 la:");
            while(n < 1000) {
                for (int i = 1; i < n; i++) {
                    if(n % i == 0) sum = sum + i;
                }
                if(sum == n) Console.WriteLine($" {n}");
                n++;
            }
        }
    }
}