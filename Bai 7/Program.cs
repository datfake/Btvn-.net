using System;

namespace Bai_7
{
    class Program
    {
        static int UCLN(int a,int b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("UCLN la {0}", Program.UCLN(a, b));
            Console.WriteLine("BCNN la {0}", (a*b)/Program.UCLN(a, b));
        }
    }
}
