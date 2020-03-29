using System;

namespace Bai_8
{
    class Program
    {
        static void decToBinary(int n)
        {
            int [] binaryNum = new int[1000];

            int i = 0;
            while (n > 0)
            {
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--) Console.Write(binaryNum[j]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            Program.decToBinary(n);
        }
    }
}
