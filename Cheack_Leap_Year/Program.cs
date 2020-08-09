using System;

namespace Cheack_Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHECK LEAP YEAR");
            Console.WriteLine("---------------------------");
            int year;
            for (; ; )
            {
                try
                {
                    Console.WriteLine("Please ! Enter year : ");
                    year = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Input error ! enter again.");
                }
            }

            if (year % 4 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
                Console.WriteLine("This is not a leap year");






        }
    }
}
