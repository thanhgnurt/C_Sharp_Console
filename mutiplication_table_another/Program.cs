using System;

namespace Mutiplication_Table_Another
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Program p = new Program();
            Console.WriteLine("MUTIPLICATION TABLE");
            for (; ; )
            {
                try
                {
                    Console.WriteLine("Please!! Enter number (note : number is a integer not 0");
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch { Console.WriteLine("Enter error . Please again."); }
            }
            
            p.mutiplication_table(number);

        }

        void mutiplication_table(int number)
        {
            for (int i = 0; i <=10; i++)
            {

                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }




    }
}
