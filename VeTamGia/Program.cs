using System;

namespace VeTamGia
{
    class Program
    {
        //kiem tra gia tri nhap
        int check_input(string tittle)
        {
            int input ;
            for(; ; )
            {
                try
                {
                    Console.WriteLine(tittle);
                    input = int.Parse(Console.ReadLine());
                    return input;

                }
                catch
                {
                    Console.WriteLine("Ban nhap sai dinh dang, Vui long nhap lai");
                }
            }
  
        }
        //ve tam giac vuong n
        void tam_giac_vuong_1()
        {
            Program p = new Program();
            int num_col = p.check_input("Hay nhap vao so cot cua tam giac");
            Console.WriteLine("Ta co tam giac vuong:");
            for(int i = 1;i<=num_col ;i++ )
            {
                for (int j = 1;j<=i ;j++ )
                {
                    Console.Write(num_col+" ");
                }
                Console.WriteLine();
            }
        }

        // tam giac vuong tu 1 den n
        void tam_giac_vuong_2()
        {
            Program p = new Program();
            int num_col = p.check_input("Hay nhap vao so cot cua tam giac");
            Console.WriteLine("Ta co tam giac vuong:");
            int num = 1;
            for(int i =1;i<=num_col ;i++ )
            {
                for (int j = 1; j <= i ;j++ )
                {
                    Console.Write(num + " ");
                    num++;
                }
                // xuong dong
                Console.WriteLine();
            }
        }

        //ve tam giac can
        void tam_giac_can()
        {
            Program p = new Program();
            int num_col = p.check_input("Hay nhap vao hang cua tam giac can");
            for (int i = num_col;i>0 ;i-- )
            {
            int count = 1;
                for (int j=1;j<=num_col*2-1 ;j++ ) {
                    // khoang ve so tren
                    int khoang_tren = 2 * num_col - i;
                    if (j>=i && j <= khoang_tren)
                    {
                        if ((i%2==0 && j%2==0 )|| (i%2!=0 && j%2!=0) ){
                            Console.Write(count);
                            count++;
                        } else
                        {
                            Console.Write(" ");
                        }
                        

                    } else
                    {
                        Console.Write(" ");
                    }
                    
                }

                //xuong dong
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {

            Console.WriteLine("Painting triangle");
            Console.WriteLine("---------------------------------------");
            bool loop = false;
            do
            {

                Program p = new Program();
                int select_triangle = p.check_input("" +
                    "Lua chon de ve tam giac: \n" +
                    "Chon 1 de ve tam giac vuong 1\n" +
                    "Chon 2 de ve tam giac vuong 2\n" +
                    "Chon 3 de ve tam giac can");

                switch (select_triangle)
                {
                    case 1:
                        p.tam_giac_vuong_1();
                        break;
                    case 2:
                        p.tam_giac_vuong_2();
                        break;
                    case 3:
                        p.tam_giac_can();
                        break;
                    default:
                        Console.WriteLine("ban lua chon sai, vui long Chon lai");
                        Console.WriteLine("--------------------");
                        loop = true;
                        break;

                }

            } while (loop);
         
            
       

            

            
            

        }
    }
}
