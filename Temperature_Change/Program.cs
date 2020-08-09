using System;

namespace Temperature_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature_c;
            Console.WriteLine("TEMPERATURE CHANGE");
            
            for (; ;)
            {
                try
                {
                    Console.WriteLine("Please! Enter Temperature C :");
                    temperature_c = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter error! Please again! ");
                }
            }
            Program p = new Program();
            p.print_temperature_change(temperature_c);

            
        }


        void print_temperature_change(int temperature_c)
        {
            int temperature_k = temperature_c + 273;
            Console.WriteLine("Temperature change to Kelvin : {0}K", temperature_k);
        }



    }
}
