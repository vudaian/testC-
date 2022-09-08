using System;
namespace bai_14
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine(" ____________________");
            Console.WriteLine("|------- Tim min, max --------|");
            Console.WriteLine("|---   1: Tam giac         ---|");
            Console.WriteLine("|---   2: Hinh vuong       ---|");
            Console.WriteLine("|---   3: Hinh chu nhat    ---|");
            Console.WriteLine("|---   3: Hinh tron        ---|");
            Console.WriteLine("|_____________________________|");
            Console.Write("Nhap lua chon: ");
            int n = int.Parse(Console.ReadLine());
            switch(n) {
                case 1:
                    tamGiac();
                    break;
                case 2: 
                    hinhVuong();
                    break;
                case 3:
                    hinhChuNhat();
                    break;
                case 4:
                    hinhTron();
                    break;
                default: 
                    Console.WriteLine("Lua chon sai!");
                    break;
            }

        }
        public static void tamGiac() {
            Console.Write("Nhap canh 1: ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh 2: ");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh 3: ");
            int c3 = Convert.ToInt32(Console.ReadLine());
            float p = (c1 + c2 + c3) / 2;
            Console.WriteLine($"Dien tich hinh tam giac la: {Math.Sqrt(p * (p - c1) * (p - c2) * (p - c3))}");
            Console.WriteLine($"Chu vi hinh tam giac la: {c1 + c2 + c3}");
        }
        public static void hinhVuong() {
            Console.Write("Nhap canh hinh vuong: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh vuong la: {c * c}");
            Console.WriteLine($"Chu vi hinh vuong la: {c * 4}");
        }
        public static void hinhChuNhat() {
            Console.Write("Nhap chieu dai: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh chu nhat la: {d * r}");
            Console.WriteLine($"Chu vi hinh chu nhat la: {(d + r) * 2}");
        }
        public static void hinhTron() {
            Console.Write("Nhap ban kinh: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh tron la: {r * r * 3.1425}");
            Console.WriteLine($"Chu vi hinh tron la: {r * 2 * 3.1425}");
        }
    }
}