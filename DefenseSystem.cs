//Emilynn Molesky
//2/1/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseOfConsolas
{
    public class DefenseSystem
    {
        //Class varibles 
        private int targetRow = -1;
        private int targetColumn = -1;

        //gets and sets 
        public int TargetRow
        {
            get { return targetRow; }
            set { targetRow = value; }
        }

        public int TargetColumn
        {
            get { return targetColumn; }
            set { targetColumn = value; }
        }

        // constructor 

        public DefenseSystem(int aTargetRow, int aTargetColumn)
        {
            this.targetRow = aTargetRow;
            this.targetColumn = aTargetColumn;
        }

        //method
        public CalcDeploy()
        {
            Console.WriteLine("Deploy to:");
            for (int i = 0; i < targetRow; i++)
            {
                int deployRow = targetRow;
                int deployColumn = targetColumn;

                return targetRow;
                return TargetColumn;
            }

           
        }
    }
}
