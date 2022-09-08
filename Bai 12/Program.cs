using System;
namespace bai_11
{
    class Program
    {
        static void Main(string[] args) 
        {
            int date, month, year;
            Console.Write("Nhap ngay: ");
            date = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
            if(year < 1000 || year > 3000) {
                Console.WriteLine($"{date} - {month} - {year} khong hop le");
            }
            else {
                if(year % 4 == 0) {
                    if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
                        if(date <= 31 && date > 0) Console.WriteLine($"{date} - {month} - {year} hop le");
                        else Console.WriteLine($"{date} - {month} - {year} khong hop le");
                    } else if(month == 4 || month == 6 || month == 9 || month == 11) {
                        if(date <= 30 && date > 0) Console.WriteLine($"{date} - {month} - {year} hop le");
                        else Console.WriteLine($"{date} - {month} - {year} khong hop le");
                    } else if(month == 2) {
                        if(date <= 29 && date > 0) Console.WriteLine($"{date} - {month} - {year} hop le");
                        else Console.WriteLine($"{date} - {month} - {year} khong hop le");
                    } else Console.WriteLine($"{date} - {month} - {year} khong hop le");
                } else {
                    if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
                        if(date <= 31 && date > 0) Console.WriteLine($"{date} - {month} - {year} hop le");
                        else Console.WriteLine($"{date} - {month} - {year} khong hop le");
                    } else if(month == 4 || month == 6 || month == 9 || month == 11) {
                        if(date <= 30 && date > 0) Console.WriteLine($"{date} - {month} - {year} hop le");
                        else Console.WriteLine($"{date} - {month} - {year} khong hop le");
                    } else if(month == 2) {
                        if(date <= 28 && date > 0) Console.WriteLine($"{date} - {month} - {year} hop le");
                        else Console.WriteLine($"{date} - {month} - {year} khong hop le");
                    } else Console.WriteLine($"{date} - {month} - {year} khong hop le");
                }
            }
        }
    }
}