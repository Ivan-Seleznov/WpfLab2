using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab2.Lab3
{
    public abstract class PrintedProduct
    {
        public PrintedProduct(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract double CalculatePrice();
    }
}
