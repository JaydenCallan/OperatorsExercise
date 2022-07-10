using System;

namespace MethodExercise
{
    class Program
    {
        public static double AreaOfCircle(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            }

            Console.WriteLine("Type the radius of the circle.");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"The area is {AreaOfCircle(radius)}");
        }
    }
}