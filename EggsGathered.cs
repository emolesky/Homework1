using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSisters
{
    public class EggsGathered
    {
        //class varibles 
        private int totalEggs = -1;
        private int eggsForSister = -1;
        private int eggsForDuckBear = -1;

        //gets and sets

        public int TotalEggs
        {
            get { return this.totalEggs; }
            set { this.totalEggs = value; }
        }

        public int EggsForSister
        {
            get { return this.eggsForSister; }
            set { this.eggsForSister = value; }
        }
        public int EggsForDuckBear
        {
            get { return this.eggsForDuckBear; }
            set { this.eggsForDuckBear = value; }
        }


        //full constuctor 
        public EggsGathered( int aTotalEggs)
        {
            this.TotalEggs = aTotalEggs;
            
            
        }

        //method

        public int CalcEggsPerSister()
        {
            int eggsPerSister = 0;

            eggsPerSister = this.totalEggs / 4;

            return eggsPerSister;

        }

        public int CalcLeftovers()
        {
            int eggsForBearDuck = 0;

            eggsForBearDuck = this.totalEggs % 4;

            return eggsForBearDuck;

        }
       
      
    }
}
