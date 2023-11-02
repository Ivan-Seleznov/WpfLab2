using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab2
{
    class Phone
    {
        public Phone() 
        {
            numberOfFunctions = 0;
        }

        public Phone(int functionsNumber)
        {
            if (functionsNumber <= 0)
            {
                throw new Exception("numberOfFunctions must be > 0");
            }

            numberOfFunctions = functionsNumber;
        }

        public virtual double CalculateCost()
        {
            return 40 * Math.Log(numberOfFunctions);
        }


        protected int numberOfFunctions;
    }
}
