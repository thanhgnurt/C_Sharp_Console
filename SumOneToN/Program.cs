using System;
using System.Globalization;

namespace SumOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hay nhap vao so n");
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            
            while (n/10>0)
            {
                result++;
                n = n / 10;

            }
            

            

            Console.WriteLine("ket qua la:{0}", result);
        }
    }
}
