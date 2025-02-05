//emiynn molesky 
//2/1/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionOfKings
{
    public class Kingdom
    {
        //gets and sets 
        private int provinces = -1;
        private int duchies = -1;
        private int estates = -1;

        //gets and sets

        public int Provinces
        {
            get { return this.provinces; }
            set { this.provinces = value; }
        }

        public int Duchies
        {
            get { return this.duchies; }
            set { this.duchies = value; }
        }

        public int Estates
        {
            get { return this.estates; }
            set { this.estates = value; }
        }

        //constructor 

        public Kingdom(int aProvinces, int aDuchies, int aEstates)
        {
            this.Provinces = aProvinces;
            this.Duchies = aDuchies;
            this.Estates = aEstates;
        }

        //methods
        public int CalcTotal()
        {
           
            int total = 0;

            total = (this.provinces * 6) + (this.duchies * 3) + (this.estates * 1);

            return total;

            

            
        }


    }
}
