using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    public abstract class FourSidedShapes : Shape //Also set to abstract so we can inherit from here and use the sides from here with inheritance.
    {
        //Adds our 2 extra sides, SideC and SideB since we only have 2 sides so far. 
        private double _sideC;
        private double _sideD;

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

        //We choose inherit our sides a, and b from shape still tho.
        protected FourSidedShapes(double sideA, string name) : base(sideA, name)
        {

        }

        protected FourSidedShapes(double sideA, double sideB, string name) : base(sideA, sideB, name)
        {

        }

        protected FourSidedShapes(double sideA, double sideB, double sideC, string name) : base(sideA, sideB, name)
        {
            //Sets our C to the value we put in as C as our extra sides, and still use our original sides from Shape
            SideC = sideC;
        }

        protected FourSidedShapes(double sideA, double sideB, double sideC, double sideD, string name) : base(sideA, sideB, name)
        {
            //Sets our C to the value we put in as C and D as our extra sides, and still use our original sides from Shape
            SideC = sideC;
            SideD = sideD;
        }
    }
}
