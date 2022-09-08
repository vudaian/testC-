using System;
namespace bai_11
{
    class Program
    {
        static void Main(string[] args) 
        {
            int month, year;
            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
            if(year % 4 == 0) {
                if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
                    Console.WriteLine($"{month} - {year} co 31 ngay");
                } else if(month == 4 || month == 6 || month == 9 || month == 11) {
                    Console.WriteLine($"{month} - {year} co 30 ngay");
                } else {
                    Console.WriteLine($"{month} - {year} co 29 ngay");
                }
            } else {
                if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
                    Console.WriteLine($"{month} - {year} co 31 ngay");
                } else if(month == 4 || month == 6 || month == 9 || month == 11) {
                    Console.WriteLine($"{month} - {year} co 30 ngay");
                } else {
                    Console.WriteLine($"{month} - {year} co 28 ngay");
                }
            }
        }
    }
}