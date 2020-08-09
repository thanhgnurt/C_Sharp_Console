using System;

namespace Thang_Co_Bao_Nhieu_Ngay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiem tra thang co bao nhie ngay");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Vui long nhap thang :");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap nam");
            int nam = int.Parse(Console.ReadLine());
            
            if (thang ==2)
            {
                if (nam % 100 == 0 && nam % 400==0 || nam % 100 != 0 && nam % 4 == 0)
                {
                    Console.WriteLine("Thang {0} nawm {1} co 29 ngay",thang, nam);
                } else
                {
                    Console.WriteLine("Thang {0} nam {1} co 28 ngay", thang, nam);
                }

            }
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                Console.WriteLine("Thang {0} nam {1} co 31 ngay", thang, nam);
            } else
            {
                if (thang != 2)
                {

                Console.WriteLine("Thang {0} nam {1} co 30 ngay", thang , nam);
                }
            }

        }
    }
}
