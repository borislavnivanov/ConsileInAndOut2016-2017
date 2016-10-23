using System;


namespace Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int result = new int();
            for (int i = numberN + 1; i < numberM; i++)
            {
                if (i % 5 == 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
