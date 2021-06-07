using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    class Paralellogram : Square
    {
        private double _sideB;

        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }

        private double _angle;

        public double Angle
        {
            get { return _angle; }
            set { _angle = value; }
        }


        public Paralellogram(double sideA, double sideB, double paralelAngle):base(sideA)
        {
            this.SideA = sideA;
            this._sideB = sideB;
            this._angle = paralelAngle;
        }


        public override double calculatePerimeter() //Override allows us to override our method in the Square class.
        {
            return (2 * SideA) + (2 * _sideB);
        }

        public override double calculateAreal()
        {
            double radian = Angle * Math.PI / 180;
            return  SideA * SideB * Math.Sin(radian);
        }
    }
}
