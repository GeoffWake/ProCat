using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ProCat
{
    class Program
    {
        static void Main(string[] args)
        {

            /////Creating Shirts
            //Shirt shirt1 = new Shirt("business",25, 12);       
            //Shirt shirt2 = new Shirt("party",30, 18);       
            //Shirt shirt3 = new Shirt("fitness",45, 22);

            /////Creating Shorts
            //Pants pants1 = new Pants("formal",15, "black");
            //Pants pants2 = new Pants("jeans",20, "blue");
            //Pants pants3 = new Pants("flared",12, "green");
            //Pants pants4 = new Pants("plain",25, "aqua");

            //Console.WriteLine(shirt1.Price);
            //Console.WriteLine(pants1.CalculateTax());

            //Catalogue<Shirt> ShirtCatalogue = new Catalogue<Shirt>();
            //Catalogue<Pants> ShortsCatalogue = new Catalogue<Pants>();

            //ShirtCatalogue.Add(shirt1);
            //ShirtCatalogue.Add(shirt2);
            //ShirtCatalogue.Add(shirt3);
            //Console.WriteLine(ShirtCatalogue);
            //Console.WriteLine(ShirtCatalogue.CalculateTotal());

            ///Console.WriteLine(shirt1.ToString);
            //Console.WriteLine(shirt1.ToString());

            //Console.WriteLine(String.Join(",", ShirtCatalogue));
            //string firstattempt = JsonSerializer.Serialize(shirt1);
            //Console.WriteLine(firstattempt);
             AddShirt.CreateShirt();
            


        }

    }

    
}