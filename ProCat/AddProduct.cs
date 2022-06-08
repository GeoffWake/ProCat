using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCat
{
    internal class AddProduct
    {
        public static Shirt CreateShirt(string style, int size, int price)
        {
            Shirt shirt5 = new Shirt(style, price, size);
            return shirt5;
        }


        public static Pants CreatePants(string style, string color, int price)
        {
            Pants pant5 = new Pants(style, price, color);
            return pant5;
        }
    }
}
