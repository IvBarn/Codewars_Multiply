using System;

namespace Codewars_Multiply
{
    class Program
    {
        public static int Multiply (int a, int b) {
            return a * b;
        }

        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter the first number to multiply: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number to multiply: ");
            b = int.Parse(Console.ReadLine());

            int result = Multiply(a, b);
            Console.WriteLine($"\nThe result of multiplying a by b: {result}");

            Console.ReadKey();
        }
    }
}
