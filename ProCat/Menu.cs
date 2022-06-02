using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCat
{


    public  class Menu
    {

        Catalogue<Shirt> ShirtCatalogue = new Catalogue<Shirt>();

        public static void MainMenu()
        {
           

            Console.WriteLine("Please select an option below:");
            Console.WriteLine("1) Create Catalogue");
            Console.WriteLine("2) View Catalogue");
            Console.WriteLine("3) Add New Product");
            Console.WriteLine("4) Remove a Product");
            Console.WriteLine("5) Remove a Catalogue");
            Console.WriteLine("6) Close Menu");

            switch (Console.ReadLine())
            {
                case "1":

                   // return true; 
                case "2":
                   Console.WriteLine("1) View Shirt Catalogue");
                   
                    if (Console.ReadLine() == "1"  )
                    {
                     Catalogue.View(ShirtCatalog)     

                    }
                   
               Console.WriteLine("2) View Pants Catalogue");

                return ;

                case "3":
                    AddShirt.CreateShirt();
                    return; 
                   // return true;

                case "4":

                   // return true;

                case "5":

                    //return true;

                case "6":

                    break;

             

            }
        }

    }
}
