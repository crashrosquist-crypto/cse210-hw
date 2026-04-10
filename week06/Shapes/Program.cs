using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 4));
        shapes.Add(new Rectangle("Blue", 10, 5));
        shapes.Add(new Circle("Green", 3));

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}