using System;


class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());


        // calcualte discriminant
        double d = (b * b) - (4 * a * c);

        // find the case of equation and calculate the result
        if (d > 0 && b % 2 != 0)
        {
            // case descriminant is above 0 and even number
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("{0:0.00}\n{1:0.00}", Math.Min(x1, x2), Math.Max(x1, x2));
        }
        else if (d > 0 && b % 2 == 0)
        {
            // case descriminant is above 0 and odd number
            double x1 = (-b - Math.Sqrt(d)) / a;
            double x2 = (-b + Math.Sqrt(d)) / a;
            Console.WriteLine("{0:0.00}\n{1:0.00}", Math.Min(x1,x2), Math.Max(x1, x2));
        }
        else if (d == 0)
        {
            // case descriminant is 0
            double x = -b / (2 * a);
            Console.WriteLine("{0:0.00}", x);
        }
        else
        {
            // case descriminant is below 0
            Console.WriteLine("no real roots");
        }

    }
}