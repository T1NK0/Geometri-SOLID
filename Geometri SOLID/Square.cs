using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    public class Square
    {
        private double _sideA;

        public double SideA
        {
            get { return _sideA; }
            set { _sideA = value; }
        }

        public Square(double sideA)
        {
            this._sideA = sideA;
        }

        public virtual double calculatePerimeter() //Virtual allows the method to be overwritten
        {
            return 4 * SideA;
        }

        public virtual double calculateAreal()
        {
            return SideA * SideA;
        }
    }
}
