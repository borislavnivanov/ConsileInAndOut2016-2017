using System;


namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            short count = short.Parse(Console.ReadLine());
            if (count == 1)
            {
                Console.Write("0");
            }
            else
            {
                Console.Write("0, 1");
            }
            
            long firstNumber = 0;
            long secondNumber = 1;
            long currentNumber;
            if (count > 2)
            {
                for (int i = 0; i < count -2; i++)
                {
                    currentNumber = firstNumber + secondNumber;
                    Console.Write(", {0}", currentNumber);
                    firstNumber = secondNumber;
                    secondNumber = currentNumber;
                }
            }
        }
    }
}
