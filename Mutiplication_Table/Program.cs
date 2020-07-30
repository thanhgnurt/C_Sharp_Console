using System;

namespace Mutiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.validation_fun();
        }


        void mutiplication_table(int number)
        {
            Console.WriteLine("This is mutiplication table {0} :", number);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            };

        }

        int input_number()
        {
            int number;
            Console.WriteLine("Choose the mutiplication tabel (enter number integer)");
            Int32.TryParse((Console.ReadLine().Trim()), out number);
            return number;
        }


        void validation_fun()
        {
            Program p = new Program();
            int number = p.input_number();
            bool validation = number != 0;
            if (validation)
            {
                p.mutiplication_table(number);
            } else
            {
                Console.WriteLine("Warning ! Invalid please enter again ! ");
                p.validation_fun();

            } 
        }



    }
}
