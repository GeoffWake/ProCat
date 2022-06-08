using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCat
{
    internal class Catalogue<T> where T : Products
    {
        public List<T> catalogue = new List<T>();
        public void Add(T product)
        {
            catalogue.Add(product);
        }


        public void Remove(T product)
        {
            catalogue.Remove(product);
        }

        public void CalculateTotal()
        {
            double Total = 0;
            foreach (Products item in catalogue)
            {
                Total += item.CalculateTax();
                Console.WriteLine($"Total Tax: {Total}");
                
            }

        }


          public void View()
          { int index = 0;

            string style;
            int price;
            int size;
            foreach ( Products product in catalogue)
             {

                index++;
                 Console.WriteLine($"{index}{product.ToString()}");
                


                
              }
          }


    }
    

}
