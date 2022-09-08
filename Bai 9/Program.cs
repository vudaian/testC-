using System;
namespace bai_9
{
    class Program 
    {
        static void Main(){
            Console.Write($"Nhap n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a, b, c, temp;
            a= n % 10;
            b = (n / 10) % 10;
            c = n / 100;
            if(a > b && a > c) {
                Console.WriteLine($"{a} So lon nhat o vi tri hang don vi");
            }
            else if(b > c && b > a) {
                Console.WriteLine($"{b} So lon nhat o vi tri hang chuc");
            }
            else if(c > a && c > b) {
                Console.WriteLine($"{c} So lon nhat o vi tri hang tram");
            }

            if(a > b) {
                temp = a;
                a = b;
                b = temp;
            }
            if(a > c) {
                temp = a;
                a = c;
                c = temp;
            }
            if(b > c) {
                temp = b;
                b = c;
                c = temp;
            }
            Console.WriteLine($"Sap xep theo thu tu tang dan la: {a}, {b}, {c}");
        }
    }
}