using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab2
{
    class MobilePhone : Phone
    {
        public MobilePhone() : base() 
        {
            Model = String.Empty;
        }
        public MobilePhone(int functionsNumber,string model) : base(functionsNumber) 
        { 
            Model = model;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() * 3;
        }

        public string Model { get; private set; }
    }
}
