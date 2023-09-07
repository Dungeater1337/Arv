using System;
using System.Collections.Generic;

class RätTriangle : Shape
{
    public RätTriangle(double width, double height) : base(width, height)
    {
       
    }

    public double Area()
    {
        double area = (width * height) / 2;
        return  area;
    }

    public double Circumference()
    {
        double kvadrat1 = height * height;
        double kvadrat2 = width * width;

        double hypotynusa = Math.Sqrt(kvadrat1 + kvadrat2);

        double omkrets = height + width + hypotynusa;
        return omkrets; 
    }
}