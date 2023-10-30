using System;
using System.IO;

namespace KMS1_06_LE_03_02
{
    public class Menu
    {
        public void Selects()

        {
            int select = 0;
            do
            {
                try
                {
                    Console.WriteLine("Herzlich Willkommen beim Getränkeautomaten Zisch!");
                    Console.WriteLine("Auswahl der Snacks und Getränke (1)");
                    Console.WriteLine("Zum Beenden des Programmnes (0)");
                    select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Snacks.DisplayMenu();
                            Snacks.SelectSnack();
                            break;

                        case 0:
                            Console.WriteLine("Vielen Dank für Ihren Besuch! Zisch wünscht Ihnen einen schönen Tag");
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
    }

}