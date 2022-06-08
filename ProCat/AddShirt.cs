using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace ProCat
{
    public class AddShirt
    {
        public static Shirt shirt5;

        public static Shirt CreateShirt()
        {

            Catalogue<Shirt> ShirtCatalogue = new Catalogue<Shirt>();


            int price = 0;
            int size = 0;
            string style = "";

            int i = 0;

            string answer = "";

         

            while (answer != "N") {
                
     
                Console.WriteLine("What is the style of the Shirt? ");
                style= Console.ReadLine();
                Console.WriteLine("What is the price of the Shirt? ");
                price = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is the size of the Shirt? ");
                size = Int32.Parse(Console.ReadLine());

                ///Add to List
                Shirt shirt5 = new Shirt(style, price, size);
                ShirtCatalogue.catalogue.Add(shirt5);








                Console.WriteLine("Would you like to add another item? Y/N");
            answer = Console.ReadLine();

            if (answer != "Y")
            {
                Menu.MainMenu();
            }

                
            }
            return shirt5;






        }




    }


}
