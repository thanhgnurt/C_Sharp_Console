using System;

namespace Swaps_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            // trao doi gia tri
            int a, b, temp;
            Console.WriteLine("Nhap gia tri a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri b :");
            b = int.Parse(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Gia tri sau khi duoc thay doi: a = {0} va b = {1}", a, b);
        }
    }
}
