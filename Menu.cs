using System;
using System.IO;

namespace KMS1_06_LE_03_02
{
    public class Menu
    {
        public  void Selects()

        {
            int select = 0;
            do
            {
                try
                {
                    NonAlcoholicDrink.InitializeDrinks();
                    Console.WriteLine("Herzlich Willkommen beim Getränkeautomaten Zisch!");
                    Console.WriteLine("Alkoholfreie Getränke (1)");
                    Console.WriteLine("Zum Beenden des Programmnes (0)");
                    select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {

                        case 1:
                            Console.WriteLine("Menü für alkoholfreie Getränke");
                            NonAlcoholicDrink.DisplayDrinks();
                            Console.WriteLine("Zur Auswahl (1." + NonAlcoholicDrink.Drinks.Count + ") oder geben Sie 0 ein, um den Automaten zu verlassen: ");
                            int input = SelectInput.GetIntInput("Geben Sie ein:");
                            SelectDrink(input);
                            break;
                        case 0:
                            Console.WriteLine("Vielen Dank für den Kauf! Zisch wünscht Ihnen einen schönen Tag");
                            return;

                        default:
                            Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine gültige Option.");

                            break;
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            } while (true);
        }
        private static void SelectDrink(int drink)
        {
            try {
                if (drink >= 1 && drink <= NonAlcoholicDrink.Drinks.Count)
                {
                    NonAlcoholicDrink selectedDrink = NonAlcoholicDrink.Drinks[drink - 1];
                    Console.WriteLine($"Sie haben {selectedDrink.Brand} gewählt. Bitte zahlen Sie {selectedDrink.GetPrice():C}");

                    double credit = 0;
                    while (credit < selectedDrink.GetPrice())
                    {
                        credit = SelectInput.GetNumericInput("Geben Sie den Geldbetrag ein, nur 5 oder 10 Euroscheine.");
                    }

                    Console.WriteLine($"Vielen Dank! Hier ist Ihr {selectedDrink.Brand}. Ihr Wechselgeld beträgt {credit - selectedDrink.GetPrice()}");
                }
            }catch (IOException ex) { Console.WriteLine( ex.ToString()); }
        }
    }
}