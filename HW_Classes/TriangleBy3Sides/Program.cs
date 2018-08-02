using System;

//Description

//Write program that calculates the surface of a triangle by given its three sides.
//Input

//    On the first line you will receive the length of the first side of the triangle
//    On the second line you will receive the length of the second side of the triangle
//    On the third line you will receive the length of the third side of the triangle

//Output

//    Print the surface of the rectangle with two digits of precision

//We are using the formula: https://en.wikipedia.org/wiki/Heron's_formula


class Heron
{
    static double HeronFormula(double a, double b, double c)
    {
        double halfPerimeter = (a + b + c) / 2;
        double surface = Math.Sqrt(halfPerimeter *
                                    (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        return surface;
    }
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", HeronFormula(sideA, sideB, sideC));
    }
}

