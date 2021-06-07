using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    class Paralellogram : Shape
    {

        private double _angle;

        public double Angle
        {
            get { return _angle; }
            set { _angle = value; }
        }


        public Paralellogram(double sideA, double sideB, double paralelAngle, string name):base(sideA, name)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
            Angle = paralelAngle;
        }


        public override double calculatePerimeter() //Override allows us to override our method in the Shape class.
        {
            return (2 * SideA) + (2 * SideB);
        }

        public override double calculateAreal()
        {
            double radian = Angle * Math.PI / 180;
            return  SideA * SideB * Math.Sin(radian);
        }
    }
}
