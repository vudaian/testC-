using System;
namespace bai_10
{
    class Program
    {
        static void Main(string[] args) 
        {
            int n;
            Console.Write("Nhap vao 1 so: ");
            n = int.Parse(Console.ReadLine());
            switch (n) {
                case 2: 
                    Console.WriteLine("Thu 2");
                    break;
                case 3:
                    Console.WriteLine("Thu 3");
                    break;
                case 4:
                    Console.WriteLine("Thu 4");
                    break;
                case 5:
                    Console.WriteLine("Thu 5");
                    break;
                case 6:
                    Console.WriteLine("Thu 6");
                    break;
                case 7:
                    Console.WriteLine("Thu 7");
                    break;
                case 8:
                    Console.WriteLine("Chu nhat");
                    break;
                default:
                    Console.WriteLine("Nhap sai thu");
                    break;
            }
        }
    }
}