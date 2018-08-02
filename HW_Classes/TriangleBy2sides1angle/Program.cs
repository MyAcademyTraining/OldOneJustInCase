using System;

//Triangle surface by two sides and an angle
//Description

//Write program that calculates the surface of a triangle by given two sides and an angle between them.
//Input

//    On the first line you will receive the length of the first side of the triangle
//    On the second line you will receive the length of the second side of the triangle
//    On the third line you will receive the angle between the given sides
//        Angle is given in degrees

//Output

//    Print the surface of the rectangle with two digits of precision


class TriangleBy2sides1angle
{
    static double SurfaceABAngle(double a, double b, double angle)
    {
        angle = (Math.PI / 180) * angle; //angle  to radians
        double surface = (a * b * Math.Sin(angle)) / 2;
        return surface;
    }
    static void Main()
    {

        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", SurfaceABAngle(sideA, sideB, angle));
    }
}

