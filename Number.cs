//Emilynn Molesky 
//2/1/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTower
{
    public class Number
    {
        //class varibles 
        private int clockNumber = 0;

        //get and set

        public int ClockNumber
        {
            get { return clockNumber; }
            set { this.clockNumber = value; }
        }

        //constructor 

        public Number(int aClockNumber)
        {
            this.clockNumber = aClockNumber;
        }


        //method

        public string CalcEvenOrOdd()
        {
            if (clockNumber % 2 == 0)
            {
                return "Tick";
            }
            else
            {
                return "Tock";
            }
        }
    }
}
