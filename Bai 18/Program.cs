using System;
namespace bai_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Nhap so can kiem tra: ");
            var n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine($"{n} la so hoan hao");
            }
            else Console.WriteLine($"{n} khong la so hoan hao");
        }
    }
}