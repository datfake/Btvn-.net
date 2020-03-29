using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            Console.WriteLine("Nhap so do 1 goc :");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nSo do goc chuyen qua ridian : {0}", (a*3.14) / 180);

        }
    }
}
