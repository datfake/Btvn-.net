using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu 3: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b)
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("Max trong 3 số {0}, {1}, {2} là {3}", a, b, c, max);

            Console.ReadKey();
        }
    }
}
