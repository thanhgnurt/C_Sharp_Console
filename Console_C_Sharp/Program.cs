using System;

namespace Console_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,z;
            float mean;
            Console.WriteLine("nhap x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri y :");
            y = int.Parse(Console.ReadLine());
            z = x + y;
            Console.WriteLine("Tong hai so {0},{1} la: {2} ", x, y, z) ;
            mean = (float)(x + y) / 2;
            Console.WriteLine("Trung binh cong la : {0}", mean);



        }
    }
}
