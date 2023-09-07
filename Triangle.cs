using System;
using System.Collections.Generic;

class Triangle : Shape
{
    public Triangle(double width, double height) : base(width, height)
    {
       
    }

    public double Area()
    {
        return  width/2 * height;
    }

    public double Circumference()
    {
        double kvadrat1 = height * height;
        double kvadrat2 = width * width;

        return Math.Sqrt(kvadrat1 + kvadrat2);
    }
}