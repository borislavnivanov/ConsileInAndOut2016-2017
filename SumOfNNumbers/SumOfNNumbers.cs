using System;


namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double result = new double();
            for (int i = 0; i < count; i++)
            {
                double a = double.Parse(Console.ReadLine());
                result = result + a;
            }
            Console.WriteLine(result);
        }
    }
}
