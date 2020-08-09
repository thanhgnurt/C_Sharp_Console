using System;

namespace Check_Triangle_With_Corner
{
    class Program
    {
        int CheckInput(string corner)
        {
            int a;
            for (; ; )
            {
                try
                {
                    Console.WriteLine("Please input {0} :", corner);
                    a = int.Parse(Console.ReadLine());
                    return a;

                }
                catch
                {
                    Console.WriteLine("You entered the wrong value, please re-enter it");
                }
            }
            
        }

        void CheckTriangle(int a, int b, int c)
        {
            if (a + b + c == 180)
            {
                Console.WriteLine("This is a triangle.");
            }
            else
                Console.WriteLine("This is not a triangle.");

        }
        static void Main(string[] args)
        {
            string again = "y";
            
            while (again == "y")
            {
                Console.WriteLine("Check the triangle through the corners");
                Console.WriteLine("---------------------------------------");
                int corner1, corner2, corner3;
                Program p = new Program();
                corner1 = p.CheckInput("corner 1");
                corner2 = p.CheckInput("corner 2");
                corner3 = p.CheckInput("corner 3");
                p.CheckTriangle(corner1, corner2, corner3);
                Console.WriteLine("Continue select y , exit select anyone key");
                again = Console.ReadLine();

            }

        }
    }
}
