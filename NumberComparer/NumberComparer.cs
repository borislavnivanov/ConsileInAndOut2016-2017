using System;


namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(numberA, numberB));
        }
    }
}
