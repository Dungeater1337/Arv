using System;
using System.Collections.Generic;
class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height)
    {
    }

    public double Area()
    {
        return width * height;
    }

    public double Circumference()
    {
        return 2 * (width + height);
    }
}