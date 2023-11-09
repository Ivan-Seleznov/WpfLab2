using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab2.Lab3
{
    public class Newspaper : PrintedProduct
    {
        public int Pages { get; set; }
        public double PageCost { get; set; }
        public int Copies { get; set; }

        public Newspaper(string name, int pages,double pageCost,int copies) : base(name)
        {
            if (copies < 0) throw new Exception("The number of copies cannot be less than zero");
            if (pageCost < 0) throw new Exception("Page cost cannot be less than zero");
            if (pages < 0) throw new Exception("The number of pages cannot be less than zero");

            Pages = pages;
            PageCost = pageCost;
            Copies = copies;
        }

        public override double CalculatePrice()
        {
            return Pages * PageCost * Copies;
        }

        public override string ToString()
        {
            return $"Газета. Name: {Name}, Pages: {Pages}, PageCost{PageCost}, Copies: {Copies}.";
        }
    }
}
