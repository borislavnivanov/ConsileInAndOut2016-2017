using System;


class CirclePerimeterAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double area = (Math.Pow(r, 2)) * (Math.PI);
        double perimeter = (2 * Math.PI) * r;

        Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
    }
}
