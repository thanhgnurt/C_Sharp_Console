using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace The_Quadratic_Equation_2
{
    class Program
    {

        static void Main(string[] args)
        {

            int a, b, c;
            Console.WriteLine("The Quadratic Equation 2");
            Console.WriteLine("-------------------");
            for (; ; )
            {
                try
                {
                    Console.WriteLine("Hay nhap gia tri hang tu binh phuong a :");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hay nhap gia tri hang tu x, b:");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hay nhap gia tri hang tu tu do c:");
                    c = int.Parse(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("Please enter again.");

                }
            };

            Program p = new Program();
            p.solveTheEquation(a, b, c);





        }

        void solveTheEquation(int a, int b, int c)
        {
            float x1, x2, delta;
            if(a == 0)
            {
                x1 = (float)-c / b;
                Console.WriteLine("Phuong trinh co mot nghiem la : x = {0}", x1);
            } else
            {
                delta = b * b - 4 * a * c;
                if (delta<0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");

                }
                if (delta == 0)
                {
                    x1 = (float)-b / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem kep : x1= x2= {0}", x1);
                    
                }
                if(delta > 0)
                {
                    delta = (float)Math.Sqrt(delta);
                    x1 =(float)(-b + delta) / (2 * a);
                    x2 =(float)(-b - delta) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem x1={0}, x2={1}", x1, x2);
                }
            }




        }






    }
}
