using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCat
{
    public class Products
    {
        public string Style { get; set; }
        public double Price { get; set; }
       

        


       //Price with a 10% Mark-Up
        public virtual double CalculateTax()
        {
            return  (Price * 10 / 100);

        }

    }
}



                