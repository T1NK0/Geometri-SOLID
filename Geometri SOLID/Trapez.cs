using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    class Trapez : FourSidedShapes
    {

        public Trapez(double sideA, double sideB, double sideC, double sideD, string name) : base(sideA, name)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }


        public override double calculatePerimeter() //Override allows us to override our method in the Shape class.
        {
            return SideA + SideB + SideC + SideD;
        }

        public override double calculateAreal()
        {
            double s = (SideA + SideB) - (SideC + SideD) / 2;
            double h = 2 / (SideA - SideC) * Math.Sqrt(s * (s - SideA + SideC) * (s - SideB) * (s - SideD));
            double a = 0.5 * (SideA + SideC) * h;
            return a;
        }
    }
}
