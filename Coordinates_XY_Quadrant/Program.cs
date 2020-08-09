using System;

namespace Coordinates_XY_Quadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coordinates (X,Y) Quadrant");
            Console.WriteLine("-------------------");
            Console.WriteLine("Please! Enter coordinates (x,y):");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x==0 && y == 0)
            {
                Console.WriteLine("coordinates(x,y) on coordinates origin");
            }
            if (x == 0 && y != 0)
            {
                Console.WriteLine("coordinates(x,y) on vertical axis ");

            }
            if (y == 0 && x!=0)
            {
                Console.WriteLine("Coordinates (x,y) on horizontal axis");
            }
            if (x>0 && y>0)
            {
                Console.WriteLine("Coordinates(x,y) on quadrant 1");
            }
            if (x>0 && y < 0)
            {
                Console.WriteLine("Coordinates(x,y) on quadrant 2");

            }
            if(x<0 && y < 0)
            {
                Console.WriteLine("Coordinates(x,y) on quadrant 3");
            }
            if(x<0 && y > 0)
            {
                Console.WriteLine("Coordinates (x,y) on quadrant 4");
            }
        }
    }
}
