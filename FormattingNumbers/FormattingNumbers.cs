﻿using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string binary = Convert.ToString(a, 2);
        string hexa = Convert.ToString(a, 16);

        Console.WriteLine("{0,-10}|{1}|{2,10:F2}|{3,-10:F3}|", hexa, binary.PadLeft(10, '0'), b, c);
    }
}