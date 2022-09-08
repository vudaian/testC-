using System;
namespace Funtion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int x = 1;
            int y = 1;
            if (n % 2 == 0) 
            {
                if (x > 3) 
                {
                    x = 0;
                }
            }
            else y = 0; 
            Console.WriteLine($"{x}");
            Console.WriteLine($"{y}");
        }
    }
}