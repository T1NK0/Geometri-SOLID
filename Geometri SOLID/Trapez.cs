using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    class Trapez : Square
    {
        private double _sideB;
        private double _sideC;
        private double _sideD;

        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }        

        public double SideC
        {
            get { return _sideC; }
            set { _sideC = value; }
        }        

        public double SideD
        {
            get { return _sideD; }
            set { _sideD = value; }
        }

        public Trapez(double sideA, double sideB, double sideC, double sideD) : base(sideA)
        {
            this.SideA = sideA;
            this._sideB = sideB;
            this._sideC = sideC;
            this._sideD = sideD;
        }


        public override double calculatePerimeter() //Override allows us to override our method in the Square class.
        {
            return 4 * SideA;
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
