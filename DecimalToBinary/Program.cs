using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string number, result;
            Console.WriteLine("DECIMAL TO BINARY");
            Console.WriteLine("Please ! enter the decimal number :");
            number =Console.ReadLine();
            int num = Convert.ToInt32(number);
            result = "";
            while (num>0)
            {
                result = Convert.ToString(num % 2) + result;
               
                num = num / 2;

            }
            Console.WriteLine("Binary number change : {0}", result);



        }
    }
}
