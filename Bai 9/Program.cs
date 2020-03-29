using System;

namespace Bai_9
{
    class Program
    {
        static int numberMax(int n)
        {
            if (n == 0) return 0;
            /*Lay tri tuyet do cua so nguyen n*/
            n = Math.Abs(n);
            int max = 0;
            while (n > 0)
            {
                int temp = n % 10;
                n /= 10;
                if (temp > max)
                    max = temp;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Chu so lon nhat la:{0}",  numberMax(n));
        }
    }
}
