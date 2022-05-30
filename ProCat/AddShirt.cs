using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

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
            
            
            Console.WriteLine("What is the style of the Shirt? ");
            style= Console.ReadLine();
            Console.WriteLine("What is the price of the Shirt? ");
            price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the size of the Shirt? ");
            size = Int32.Parse(Console.ReadLine()); 

            Shirt shirt5=new Shirt(style, price, size); 
            
            ShirtCatalogue.Add(shirt5);
            Console.WriteLine(shirt5);

            string addList = JsonSerializer.Serialize(shirt5) + Environment.NewLine;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "catalogue.json");
            File.AppendAllText(filePath, addList);

            
            
            Shirt dest = JsonSerializer.Deserialize<Shirt>(addList);
            Console.WriteLine(dest);    

        }


        public static void Remove()
        {

            
        }


    }
   
}
