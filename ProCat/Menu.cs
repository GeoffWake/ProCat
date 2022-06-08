using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProCat
{


    public static  class Menu
    {
        static Catalogue<Pants> PantsCatalogue = new Catalogue<Pants>();
        static  Catalogue<Shirt> ShirtCatalogue = new Catalogue<Shirt>();

        public static  void MainMenu()
        {
            int answer = 0;
            while (answer != 6)
            {

            Console.WriteLine("Please select an option below:");
            
            Console.WriteLine("1) View Catalogue");
            Console.WriteLine("2) Add New Product");
            Console.WriteLine("3) Remove a Product");
            Console.WriteLine("4) Remove a Catalogue");
            Console.WriteLine("5) Save and Quit");

                switch (Console.ReadLine())
                {
                   

                    // return true; 
                    case "1":


                        Console.WriteLine("1) View Shirt Catalogue");
                        Console.WriteLine("2) View Pants Catalogue");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    {
                                        Console.WriteLine("");
                                        ShirtCatalogue.View();
                                        Console.WriteLine("");
                                        ShirtCatalogue.CalculateTotal();
                                        Console.WriteLine("");
                                        //foreach(Shirt shirt in ShirtCatalogue)
                                        //  {
                                        //      Console.WriteLine(shirt.ToString);
                                        //  }
                                        Menu.MainMenu();
                                    }

                                }
                                break;
                            case "2":
                                {
                                    {

                                        Console.WriteLine("");
                                        PantsCatalogue.View();
                                        Console.WriteLine("");
                                        PantsCatalogue.CalculateTotal();
                                        Menu.MainMenu();
                                    }

                                }
                                break;
                        }
                        return;


                    case "2":

                        Console.WriteLine("1) Add Shirt to Catalogue");
                        Console.WriteLine("2) Add Pants to Catalogue");
                        switch (Console.ReadLine())
                        {
                            case "1":

                                {
                                    string p = "";
                                    while (p != "N")
                                    {

                                        Console.WriteLine("What is the style of the Shirt? ");
                                        string style = Console.ReadLine();
                                        Console.WriteLine("What is the price of the Shirt? ");
                                        int price = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("What is the size of the Shirt? ");
                                        int size = Int32.Parse(Console.ReadLine());

                                        ///Use Add Product Function to create shirt
                                        Shirt shirt5 = AddProduct.CreateShirt(style, price, size);
                                        ShirtCatalogue.catalogue.Add(shirt5);

                                        Console.WriteLine("Would you like to add another item? Y/N");
                                        p = Console.ReadLine();
                                        if (p != "Y")
                                        {
                                            Menu.MainMenu();
                                        }
                                    }
                                }
                                break;
                            ///Pants spot Console.WriteLine("2) Add Pants to Catalogue");
                            case "2":

                                {
                                    string p = "";
                                    while (p != "N")
                                    {

                                        Console.WriteLine("What is the style of the Pants? ");
                                        string style = Console.ReadLine();
                                        Console.WriteLine("What is the price of the Pants? ");
                                        int price = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("What is the color of the Pants? ");
                                        string color = Console.ReadLine();

                                        ///Use Add Product Function to create shirt
                                        Pants pant5 = AddProduct.CreatePants(style, color, price);
                                        PantsCatalogue.catalogue.Add(pant5);

                                        Console.WriteLine("Would you like to add another item? Y/N");
                                        p = Console.ReadLine();
                                        if (p != "Y")
                                        {
                                            Menu.MainMenu();
                                        }
                                    }
                                }
                                break;

                        }
                    

                        break;

                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("1) Remove Shirt from Catalogue");
                        Console.WriteLine("2) Remove Pants from Catalogue");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                string t = "";
                                while (t != "N")
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Please enter the number of the item you would like removed? ");
                                    int remove = Convert.ToInt32(Console.ReadLine());


                                    ///Remove item

                                    ShirtCatalogue.catalogue.RemoveAt(remove);
                                    Console.WriteLine("");
                                    Console.WriteLine("Would you like to remove another item? Y/N");
                                    t = Console.ReadLine();
                                    if (t != "Y")
                                    {
                                        Menu.MainMenu();
                                    }

                                }
                                break;
                            case "2":
                                string a = "";
                                while (a != "N")
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Please enter the number of the item you would like removed? ");
                                    int remove = Convert.ToInt32(Console.ReadLine());


                                    ///Remove item

                                    PantsCatalogue.catalogue.RemoveAt(remove);
                                    Console.WriteLine("");
                                    Console.WriteLine("Would you like to remove another item? Y/N");
                                    a = Console.ReadLine();
                                    if (a != "Y")
                                    {
                                        Menu.MainMenu();
                                    }
                                    break;


                                }
                                break;
                        }
                        break;

                    case "4":
                        Console.WriteLine("");
                        Console.WriteLine("1) Remove Shirt Catalogue");
                        Console.WriteLine("2) Remove Pants Catalogue");
                        switch (Console.ReadLine())

                        { case "1":

                                {
                                    Console.WriteLine("");

                                    Console.WriteLine("");
                                    ShirtCatalogue.catalogue.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("The Shirt Catalogue has been cleared");
                                    Console.WriteLine("");
                                    Menu.MainMenu();
                                }
                                break;
                            case "2":

                                {
                                    Console.WriteLine("");

                                    Console.WriteLine("");
                                    PantsCatalogue.catalogue.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("The Pants Catalogue has been cleared");
                                    Console.WriteLine("");
                                    Menu.MainMenu();
                                }
                                break;
                        }
                        return;




                
                                //return true;

                                case "5":
                                string ShirtPath = Path.Combine(Directory.GetCurrentDirectory(), "shirtlistinfo.json");
                                string addshirt = JsonSerializer.Serialize(ShirtCatalogue.catalogue);
                                File.WriteAllText(ShirtPath, addshirt);

                                string PantsPath = Path.Combine(Directory.GetCurrentDirectory(), "pantslistinfo.json");
                                string addPants = JsonSerializer.Serialize(PantsCatalogue.catalogue);
                                File.WriteAllText(PantsPath, addPants);    

                                 break;

             

                                      }
                break;
            }





        }

    }
}
