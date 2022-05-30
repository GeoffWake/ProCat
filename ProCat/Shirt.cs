using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCat
{
    internal class Shirt: Products
    {
        public int Size { get; set; }

        public Shirt ( string style, double price, int size)
        {
            Price = price;
            Size = size;  
            Style = style;
        }

        public Shirt() { } ///Default Constructor

       
    }
}
