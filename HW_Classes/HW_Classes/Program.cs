using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Triangle surface by side and altitude
//Description

//Write program that calculates the surface of a triangle by given a side and an altitude to it.
//Input

//    On the first line you will receive the length of a side of the triangle
//    On the second line you will receive the altitude to that side

    
    class HW_Classes
    {
        static void Main(string[] args)
        {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}",(side*height/2));
        }
    }

