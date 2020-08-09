using System;

namespace Aquation_XY
{
    class Program
    {
        static void Main(string[] args)
        {
            // x = y^2 -2*y + 1 (y =(-5,5))
            for (int i=-5; i<=5; i++)
            {
                int x;
             
                x = i * i - 2 * i + 1;
                Console.WriteLine("voi y = {0} thi x = {1}", i, x);
            }
        }
    }
}
