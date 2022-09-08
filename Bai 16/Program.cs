using System;
namespace bai_16
{
    class Program
    {
        static void Main(string[] args)
        {
             int a, b, c;
            Console.Write("Nhap canh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = Convert.ToInt32(Console.ReadLine()); 

            if(a + b < c || a + c < b || b + c < a) {
                Console.WriteLine("Day khong phai 3 canh cua tam giac!");
            } else {
                if(a * a + b * b  == c * c || a * a + c * c == b * b || b * b + c * c == a * a) {
                    if(a == b || a == c || c == b) {
                        Console.WriteLine("Day la 3 canh cua tam giac vuong can!");
                    } else {
                        Console.WriteLine("Day la 3 canh cua tam giac vuong!");
                    }
                } else if(a == b && c == a) {
                    Console.WriteLine("Day la 3 canh cua tam giac deu!");
                } else if(a == b || a == c || c == b) {
                    Console.WriteLine("Day la 3 canh cua tam giac can!");
                } else {
                    Console.WriteLine("Day la 3 canh cua tam giac thuong!");
                }
            }
        }
    }
}