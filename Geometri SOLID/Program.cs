using System;

namespace Geometri_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kvadrat");
            Square square = new Square(90);
            Console.WriteLine("Omkreds: " + square.calculatePerimeter());
            Console.WriteLine("Areal: " + square.calculateAreal());

            Console.WriteLine();

            Console.WriteLine("Rektangel");
            Rektangel rektangel = new Rektangel(20, 40);
            Console.WriteLine("Omkreds: " + rektangel.calculatePerimeter());
            Console.WriteLine("Areal: " + rektangel.calculateAreal());

            Console.WriteLine();

            Console.WriteLine("Paralellogram");
            Paralellogram paralellogram = new Paralellogram(20, 30, 5);
            Console.WriteLine("Omkreds: " + paralellogram.calculatePerimeter());
            Console.WriteLine("Areal: " + paralellogram.calculateAreal());

            Console.WriteLine();

            Console.WriteLine("Trapez");
            Trapez trapez = new Trapez(50, 15, 30, 15);
            Console.WriteLine("Omkreds: " + trapez.calculatePerimeter());
            Console.WriteLine("Areal: " + trapez.calculateAreal());

            Console.ReadLine();
        }
    }
}
