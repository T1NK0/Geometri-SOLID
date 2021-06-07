using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    class Sides
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _sideD;

        public double SideA
        {
            get { return _sideA; }
            set { _sideA = value; }
        }
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
        public double MyProperty
        {
            get { return _sideD; }
            set { _sideD = value; }
        }

        public Sides (double sideA)
        {

        }

        public Sides(double sideA, double sideB)
        {

        }

        public Sides(double sideA, double sideB, double sideC)
        {

        }

        public Sides(double sideA, double sideB, double sideC, double sideD)
        {

        }
    }
}
