using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            Console.WriteLine("Nhap do C :");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDo f cua no : {0}", (a * 1.8) +32);
        }
    }
}
