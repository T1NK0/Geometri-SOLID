using System;
using System.Collections.Generic;

namespace Geometri_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //My list where i add my objects
            List<Shape> shapes = new List<Shape>();

            //My objects
            Square square = new Square(90, "Kvadrat");
            Rektangel rektangel = new Rektangel(20, 40, "Rektangel");
            Paralellogram paralellogram = new Paralellogram(20, 30, 5, "Paralellogram");
            Trapez trapez = new Trapez(50, 15, 30, 15, "Trapez");
            Triangle triangle = new Triangle(25, 25, "Retvinklet Trekant");

            //Console.WriteLine("Kvadrat");
            //Console.WriteLine("Omkreds: " + square.calculatePerimeter());
            //Console.WriteLine("Areal: " + square.calculateAreal() + "\n");

            //Console.WriteLine("Rektangel");
            //Console.WriteLine("Omkreds: " + rektangel.calculatePerimeter());
            //Console.WriteLine("Areal: " + rektangel.calculateAreal() + "\n");

            //Console.WriteLine("Paralellogram");
            //Console.WriteLine("Omkreds: " + paralellogram.calculatePerimeter());
            //Console.WriteLine("Areal: " + paralellogram.calculateAreal() + "\n");

            //Console.WriteLine("Trapez");
            //Console.WriteLine("Omkreds: " + trapez.calculatePerimeter());
            //Console.WriteLine("Areal: " + trapez.calculateAreal() + "\n");

            //Console.WriteLine("Retvinklet Trekant");
            //Console.WriteLine("Omkreds: " + triangle.calculatePerimeter());
            //Console.WriteLine("Areal: " + triangle.calculateAreal());

            //Console.WriteLine("--------------");

            shapes.Add(square);
            shapes.Add(rektangel);
            shapes.Add(paralellogram);
            shapes.Add(trapez);
            shapes.Add(triangle);

            //Loop through the shapes in the list.
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Name + "\n" + shape.calculateAreal() + "\n" + shape.calculatePerimeter() + "\n" + "\n");
            }

            Console.ReadLine();
        }
    }
}
