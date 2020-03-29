using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap lan luot diem 3 mon :");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDiem trong binh 3 mon la : {0}",(a+b+c)/3);

        }
    }
}
