using System;
namespace Check_number
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 0) {
                Console.Write($"{n} la so am");
                if(n % 2 == 0) {
                    Console.Write($" va la so chan");

                } else {
                    Console.Write($" va la so le");
                }
            } else {
                Console.Write($"{n} la so duong");
                if(n % 2 == 0) {
                    Console.Write($" va la so chan");

                } else {
                    Console.Write($" va la so le");
                }
            } 
            
        }
        
    }
}