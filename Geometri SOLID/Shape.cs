using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_SOLID
{
    public abstract class Shape //Set to abstract, so we can inherit from it, and not instantiate it.
    {
        //Here we make our a side and b side, since all objects has 2 sides minimum.
        private string _name;
        private double _sideA;
        private double _sideB;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
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


        public Shape (double sideA, string name)
        {
            Name = name;
            SideA = sideA;
        }

        public Shape(double sideA, double sideB, string name)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
        }

        //Here we cerate our calculation methods we use and override through our project.
        //Creates methods, where we use these two methods all classes who inherits from Shape use, but with their own version of calculations.
        public abstract double calculatePerimeter();

        public abstract double calculateAreal();
    }
}
