using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkone
{
    internal class Triangle
    {
        //class varibles
        private double baseOfTriangle = -1.0;
        private double heightOfTriangle = -1.0;

        //gets and sets

        public double BaseOfTriangle
        {
            get { return this.baseOfTriangle; }
            set { this.baseOfTriangle = value; }

        }
        public double HeightOfTriangle
        {
            get { return this.heightOfTriangle; }
            set { this.heightOfTriangle = value; }
        }

        //constructor 

        public Triangle(double aBaseOfTriangle, double aHeightOfTriangle)
        {
            this.BaseOfTriangle = aBaseOfTriangle;
            this.HeightOfTriangle = aHeightOfTriangle;

        }


        //method
        public double CalcArea()
        {
            double area = 0.0;

            area = (this.heightOfTriangle * this.baseOfTriangle) / 2;

            return area ;

        }

    }
}
