using System;

namespace Show_Number_Hexan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hien thi so hexan tu 0 den 255");
            Console.WriteLine("-------------------------------");
            for (int i=0; i<=255; i++)
            {
                if (i < 16)
                {
                    Console.Write("0");
                }
                string a = Convert.ToString(i, 16);
                Console.Write("{0} ", a);
                if ((i + 1) % 16 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
