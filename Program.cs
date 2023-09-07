using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args)
    {

        Console.WriteLine("Ange höjden: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Ange bredden: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Skriv in 'T' för triangel, eller 'R' för en rektangel");
        char choice = Console.ReadKey().KeyChar;

        if(choice == 'T' || choice == 't'){
            Triangle triangle = new Triangle(width, height);
            double Area = triangle.Area();
            double Circumference = triangle.Circumference();

            Console.WriteLine("\nTriangelns area är: " + Area + " a.e " + " Dess omkrets är: " + Circumference + " a.e ");
        }

        else if(choice == 'R' || choice == 'r'){
            Rectangle rectangle = new Rectangle(width, height);
            double Area = rectangle.Area();
            double Circumference = rectangle.Circumference();

            Console.WriteLine("\nRektangelns area är: " + Area + " a.e " + " Dess omkrets är: " + Circumference + " a.e ");
        } 
    }
}