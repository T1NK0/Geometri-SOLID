using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    class Rektangel : Square
    {
        private double _sideB;

        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }

        public Rektangel(double sideA, double sideB) : base(sideA)
        {
            this.SideA = sideA;
            this._sideB = sideB;
        }

        public override double calculatePerimeter() //Override allows us to override our method in the Square class.
        {
            return (2 * SideA) + (2 * SideB);
        }

        public override double calculateAreal()
        {
            return SideA * SideB;
        }
    }
}
