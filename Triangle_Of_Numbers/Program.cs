using System;

namespace Triangle_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, colum;
            Console.WriteLine("TRIANGLE OF NUMBER");
            for( ; ; )
            {
                try
                {
                    Console.WriteLine("Please enter the number represention of the triangle : ");
                    number = int.Parse(Console.ReadLine());
                    break;
                } 
                catch
                {
                    Console.WriteLine("Enter represention of the triangle error !! please again :");
                }
            }

            for ( ; ; )
            {
                try
                {
                    Console.WriteLine("Please enter the number colums of the triangle");
                    colum = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter represention of the triangle error !! please again :");
                }

            }

            Program p = new Program();
            p.Print_Triangle(number, colum);

            p.Print_Equilateral_Triangle(number, colum);

            

        }

        void Print_Triangle(int number, int colum)
        {
            Console.WriteLine("This is the triangle {0} with colums {1}", number, colum);
            for(int i=1; i<=colum; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write(number + " ");

                }
                Console.WriteLine("");
            }
        }

        void Print_Equilateral_Triangle(int number, int colum)
        {
            if (colum % 2 == 0)
            {
                Console.WriteLine("Do not write equilateral triangle with colum even number");
            } else
            {
                for(int i=1; i<=colum; i++)
                {
                    for (int j=1; j<colum*2; j ++)

                    {
                        if (j > colum - i && j < colum + i )
                        {
                            if (i % 2 != 0)
                            {
                                if (j % 2 != 0)
                                {

                                    Console.Write(number);
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                               
                            } else
                            {
                                if (j %2 ==0)
                                {

                                    Console.Write(number);
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                                
                            }

                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }
                Console.WriteLine("");
                }
            }
        }


    }
}
