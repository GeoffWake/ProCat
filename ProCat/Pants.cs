using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCat
{
    public class Pants: Products
    {

        string style;
        int price;
        int size;
        int index = 0;
        string color;

        Catalogue<Pants> PantsCatalogue = new Catalogue<Pants>();
        public string Color { get; set; }
        public Pants ( string style, int price, string color)
        {
            Price = price;  
            Color = color; 
            Style = style;

            this.price = price;
            this.Color = color;
            this.style = style;
        }

        public Pants() { } ///Default Constructor

        public override string ToString()
        {
            return $" Style: {style} Price: ${price} Color: {color}";
           
        }
    }
}
