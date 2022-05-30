using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCat
{
    internal class Pants: Products
    {
        public string Color;
        public Pants ( string style, double price, string color)
        {
            Price = price;  
            Color = color; 
            Style = style;
        }
    }
}
