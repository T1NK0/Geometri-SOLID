using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    public class Square : Shape
    {
        public Square(double sideA, string name):base(sideA, name)
        {
            Name = name;
            SideA = sideA;
        }

        public override double calculatePerimeter() //Override allows us to override our method in the Shape class.
        {
            return 4 * SideA;
        }

        public override double calculateAreal()
        {
            return SideA * SideA;
        }
    }
}
