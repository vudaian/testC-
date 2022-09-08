using System;
namespace bai_20
{
    class Program
    {
        static void Main(string[] args) {
                
            Console.Write("Nhap n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            int a, b, c;
            a = n % 10;
            b = (n / 10) % 10;
            c = n / 100;
        
            if(n < 100 || n > 999){
              Console.Write("Nhap so co ba chu so!");
            }
            else{
              switch(c){
                case 1:Console.Write("Mot tram ");break;
                case 2:Console.Write("Hai tram ");break;
                case 3:Console.Write("Ba tram ");break;
                case 4:Console.Write("Bon tram ");break;
                case 5:Console.Write("Nam tram ");break;
                case 6:Console.Write("Sau tram ");break;
                case 7:Console.Write("Bay tram ");break;
                case 8:Console.Write("Tam tram ");break;
                case 9:Console.Write("Chin tram ");break;
              }
              if(b % 10 == 0 && a != 0){
              Console.Write("linh ");
              }
              switch(b){
                case 1:Console.Write("muoi ");break;
                case 2:Console.Write("hai muoi ");break;
                case 3:Console.Write("ba muoi ");break;
                case 4:Console.Write("bon muoi ");break;
                case 5:Console.Write("nam muoi ");break;
                case 6:Console.Write("sau muoi ");break;
                case 7:Console.Write("bay muoi ");break;
                case 8:Console.Write("tam muoi ");break;
                case 9:Console.Write("chin muoi ");break;
              }
              switch(a){
                case 1:Console.Write("mot ");break;
                case 2:Console.Write("hai ");break;
                case 3:Console.Write("ba ");break;
                case 4:Console.Write("bon ");break;
                case 5:Console.Write("lam ");break;
                case 6:Console.Write("sau ");break;
                case 7:Console.Write("bay ");break;
                case 8:Console.Write("tam ");break;
                case 9:Console.Write("chin ");break;
              }
            }
        }
    }
}
    
