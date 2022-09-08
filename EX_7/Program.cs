using System;
namespace EX_7
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Nhung so can tim la:");
            for(int i = 10; i < 100; i++) {
                int a = i / 10;
                int b = i % 10;
                if(a * b == (a + b) * 2) {
                    Console.Write($" {i} ");
                }
            }
        }
    }
}