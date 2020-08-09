using System;

namespace Symbol_Or_Char_Or_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SYMBOL OR CHAR OR NUMBER");
            Console.WriteLine("Please enter the one key :");
            char symbol;
            symbol = Convert.ToChar(Console.ReadLine());
            if((symbol >='0')&& (symbol <= '9'))
            {
                Console.WriteLine("Symbol is a number.");
            } else
            {
                if (symbol == 'u' || symbol =='e' || symbol =='o' || symbol=='a'||symbol =='i')
                {
                    Console.WriteLine("Symbol is a vowel.");
                }
                else
                {
                    Console.WriteLine("Symbol is not a vowel and number");
                }
            }
        }
    }
}
