using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    class Triangle : FourSidedShapes
    {
        public Triangle(double sideA, double sideB, string name) : base(sideA, name)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
        }

        public override double calculatePerimeter() //Override allows us to override our method in the Shape class.
        {
            return SideA + SideB + (Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2))); //Math delen udregner siden c via 
        }

        public override double calculateAreal()
        {
            return 0.5 * SideA * SideB;
        }
    }
}
