using System;
using System.Collections.Generic;
using System.IO;

namespace KMS1_06_LE_03_02
{
    public class NonAlcoholicDrink
    {
        public string Brand { get; }
        public double Contents { get; }
        public string ContendDrink { get; }
        private double Price { get; }

        public static List<NonAlcoholicDrink> Drinks { get; private set; } = new List<NonAlcoholicDrink>();

        public NonAlcoholicDrink(string brand, double price, double contents, string contendDrink)
        {
            Brand = brand;
            Price = price;
            Contents = contents;
            ContendDrink = contendDrink;
        }

        public double GetPrice()
        {
            return Price;
        }

        public static void InitializeDrinks()
        {
            Drinks = new List<NonAlcoholicDrink>
            {
                new NonAlcoholicDrink("Coca Cola",3.60,1.00, "Zucker, Zitronensäure, Wasser"),
                new NonAlcoholicDrink("Coca Cola",1.80,0.5, "Zucker, Zitronensäure, Wasser"),
                new NonAlcoholicDrink("Fanta",3.60,1.00, "Zucker, Zitronensäure, Wasser"),
                new NonAlcoholicDrink("Fanta",1.80,0.5, "Zucker, Zitronensäure, Wasser"),
                new NonAlcoholicDrink("Almdudler",3.60,1.00, "Zucker, Zitronensäure, Kräuter, Wasser"),
                new NonAlcoholicDrink("Almdudler",1.80,0.5, "Zucker, Zitronensäure, Kräuter Wasser"),
                new NonAlcoholicDrink("Sprit",3.60,1.00, "Zucker, Zitronensäure, Wasser"),
                new NonAlcoholicDrink("Sprit",1.80,0.5, "Zucker, Zitronensäure, Wasser"),
                new NonAlcoholicDrink("Mineralwasser",2.40,1.00, "Quellwasser, Kohlensäure"),
                new NonAlcoholicDrink("Mineralwasser",1.20,0.5, "Quellwasser, Kohlensäure"),
                new NonAlcoholicDrink("Apfelsaft",1.60,1.00, "Bio-Äpfel"),
                new NonAlcoholicDrink("Apfelsaft",3.20,0.5, "Bio-Äpfel"),
                new NonAlcoholicDrink("Birnennektar",3.60,1.00, "Bio-Birnen"),
                new NonAlcoholicDrink("Birnennektar",1.80,0.5, "Bio-Birnen"),

            };
        }

        public static void DisplayDrinks()
        {
            try
            {
                for (int i = 0; i < Drinks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Drinks[i].Brand} Preis: {Drinks[i].GetPrice()} Flaschengröße: {Drinks[i].Contents} Inhalsstoffe: {Drinks[i].ContendDrink}");
                }
            }
            catch (IOException ex) { Console.WriteLine(ex.ToString()); }
        }


    }
    
}
