using System;

namespace Bai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            int res = 0,tmp;
            while (n > 0)
            {
                tmp = n % 10;
                res = res * 10 + tmp;
                n = n / 10;
            }
            Console.WriteLine(res);
        }
    }
}
