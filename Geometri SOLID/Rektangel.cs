using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    class Rektangel : Shape
    {

        public Rektangel(double sideA, double sideB, string name) : base(sideA, name)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
        }

        public override double calculatePerimeter() //Override allows us to override our method in the Shape class.
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
        }

        public override double calculateAreal()
        {
            return SideA * SideB;
        }
    }
}
