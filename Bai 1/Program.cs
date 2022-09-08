using System;
namespace baitap_1
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.Write("Nhap ky tu: ");
            char kytu = (char)Console.Read();
            if((kytu >= 97 && kytu <= 122) || (kytu >= 65 && kytu <= 90)) 
            {
                Console.WriteLine($"{kytu} la chu cai");
            } else Console.WriteLine($"{kytu} khong la chu cai");
        }
    }
}
