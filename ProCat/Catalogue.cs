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

        public double CalculateTotal()
        {
            double Total = 0;
            foreach (Products item in catalogue)
            {
                Total += item.CalculateTax();
            }

            return Total;
        }


     
        public void View(IEnumerable<T> catalogue)
        {
            foreach (Products product in catalogue)
            {
                Console.WriteLine(product);    
            }
        }
    }


}
