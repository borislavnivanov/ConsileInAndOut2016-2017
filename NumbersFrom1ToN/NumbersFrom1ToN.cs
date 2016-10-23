using System;


namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
