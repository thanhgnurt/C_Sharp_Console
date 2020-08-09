using System;

namespace LoginBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            for(int i=1;i<=3 ;i++ )
            {
            Console.WriteLine("Please enter username :");
            username = Console.ReadLine();
            Console.WriteLine("Please enter password :");
            password = Console.ReadLine();
            if (username=="username" && password=="password")
            {
                Console.WriteLine("Login success");
                    break;
            } else
            {
                    if (i ==3)
                    {

                Console.WriteLine("Login faild");
                        break;
                    }
                    Console.WriteLine("Please enter again!");
            }
            }
            

        }
    }
}
