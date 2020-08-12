using System;

namespace TongCacSoChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tong ca so chan hoac le.");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Ban muon tinh tong le nhap 1, tong chan nhap 2");
            int.TryParse(Console.ReadLine(),out int select);
            int number, sum=0;

            if (select == 1)
            {
                Console.WriteLine("Hay nhap so nguyen bat ky, ban se co tong le cac so tu 1");
                int.TryParse(Console.ReadLine(), out number);
                int i = 1;
                while (i<=number)
                {
                    sum += i;
                    i += 2;
                }


            }
            if (select ==2)
            {
                Console.WriteLine("Hay nhap so nguyen bat ky, ban se co tong so chan tu 1 den so nguyen do");
                int.TryParse(Console.ReadLine(), out number);
                int i = 2;
                while(i <= number)
                {
                    sum += i;
                    i += 2;
                }
            }
            if(select!=1 & select!=2)
            {
                Console.WriteLine("Ban da lua chon sai.");
            }

            if (sum != 0)
            {
                Console.WriteLine("Ban co tong la: {0}", sum);
            }
            

        }
    }
}
