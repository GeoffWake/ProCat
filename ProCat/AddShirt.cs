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

      
        public static void CreateShirt()
        {

            Catalogue<Shirt> ShirtCatalogue = new Catalogue<Shirt>();


            double price = 0;
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
               
                

                // string addList = JsonSerializer.Serialize(shirt5) ;
                string addList = JsonSerializer.Serialize(ShirtCatalogue.catalogue); //+ Environment.NewLine;///New line

                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "catalogue.json");
                File.AppendAllText(filePath, addList);




                Console.WriteLine("Would you like to add another item? Y/N");
                answer = Console.ReadLine();

                if (answer != "Y")
                {
                     Menu.MainMenu();
                }


                

            }

          




        }




    }


}
