using System;

namespace Check_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, temp;
            Console.WriteLine("Check Triangle");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Input 3 edge triangle:");
            Console.WriteLine("Enter edge a:");
            int.TryParse(Console.ReadLine(),out a);
            Console.WriteLine("Enter edge b:");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Enter edge c:");
            int.TryParse(Console.ReadLine(), out c);

            int[] arrayEdge = { a,b,c };
            Console.WriteLine(arrayEdge);
            int i = 0;

            //sap xep theo thu tu tang dan so do cac canh
            while (i<arrayEdge.Length){
                int j = i+1;
                while(j < arrayEdge.Length )
                { 
                    if (arrayEdge[i] > arrayEdge[j])
                    {
                        temp = arrayEdge[i];
                        arrayEdge[i] = arrayEdge[j];
                        arrayEdge[j] = temp;

                    }

                    j++;
                }
                i++;
               
                
            }
            a = arrayEdge[0];
            b = arrayEdge[1];
            c = arrayEdge[2];
            //kiem tra dieu kien de co 1 tam giac
            if (c > a +b)
            {
                Console.WriteLine("This is not a triangle");


            } else
            {
                //kiem tra tam giac can
            if (c*c == a*a + b*b)
            {
                if(a == b)
                {
                    Console.WriteLine("This is a triangle right angle");
                } else

                Console.WriteLine("This is a right triangle ");
            } 
            
           

         
            //kiem tra tam giac tu
            if (c*c > a*a +b*b)
            {
                    if (a==b)
                    {
                        Console.WriteLine("This is a isosceles triangle");

                    } else
                Console.WriteLine("This is a prison triangle");



            }
            //kiem tra tam giac nhon
            if (c*c < a*a + b*b)
            {
                    if (a == b || a == c || b == c)
                    {
                        if (a == b && a == c)
                        {
                            Console.WriteLine("This is a equilateral triangle ");
                        }
                        else
                        {
                            Console.WriteLine("This is a isosceles triangle");
                        }

                    } else
                    {

                    Console.WriteLine("This is a pointed triangle ");
                    }
            }
            
            }

           


            


            



        }
    }
}
