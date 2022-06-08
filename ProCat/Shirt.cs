using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCat
{
    public class Shirt: Products
    {

        string style;
        int price;
        int size;
        int index = 0;

        public int Size { get; set; }
        ///public int Price { get; set; }

        Catalogue<Shirt> ShirtCatalogue = new Catalogue<Shirt>();
        public Shirt ( string style, int price, int size)
        {
            Price = price;
            Size = size;  
            Style = style;


            this.price = price;
            this.size = size;
            this.style = style;
        }

        public Shirt() { } ///Default Constructor




        public override string ToString()
        {
            return    $" Style: {style} Size: {price} Price: $ {size}";
           
        }





    }
}
