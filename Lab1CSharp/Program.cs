using System;

namespace Lab1CSharp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter 1 number : ");
            double kub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2 number : ");
            double kub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cube of the sum of 2 numbers = ");
            Console.WriteLine(Math.Pow(kub1 + kub2, 3));
        }
    }
}
