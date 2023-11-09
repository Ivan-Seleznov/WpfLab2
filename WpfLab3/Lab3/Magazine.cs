using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab2.Lab3
{
    public class Magazine : PrintedProduct
    {
        public Magazine(string name,int copies,double price) : base(name)
        {
            if (copies < 0) throw new Exception("The number of copies cannot be less than zero");
            if (price < 0) throw new Exception("Price cannot be less than zero");

            Copies = copies;
            Price = price;

            Name = "Журнал: " + Name;
        }

        public int Copies { get; set; }
        public double Price { get; set; }

        public override double CalculatePrice()
        {
            return Copies * Price;
        }
        public override string ToString()
        {
           return $"Журнал. Name: {Name}, Price: {Price}, {Copies}.";
        }
    }
}
