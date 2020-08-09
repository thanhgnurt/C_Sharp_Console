using System;

namespace Check_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHECK TWO NUMBER");
            Console.WriteLine("Please . Enter number a :");
            int a;
            int.TryParse(Console.ReadLine(),out a);
            Console.WriteLine("Please . Enter number b: ");
            int b;
            int.TryParse(Console.ReadLine(), out b);
            int c = a - b;
            if (c==0)
            {
                Console.WriteLine("a and b equal.");

            } else
            {
                if (c>0)
                {
                    Console.WriteLine("a bigger b");
                } else
                {
                    Console.WriteLine("b bigger a");
                }
            }
        }
    }
}
