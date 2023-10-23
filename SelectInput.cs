using System;
namespace KMS1_06_LE_03_02
{
    public class SelectInput
    {
        public static double GetNumericInput(string input)
        {
            double value = 0;
            bool checkInput = false;
            while (!checkInput)
            {
                Console.WriteLine(input);
                string inputUser = Console.ReadLine();
                try
                {
                    if (inputUser == "5" || inputUser == "10" || inputUser == "5.0" || inputUser == "10.0")
                    {
                        value = Convert.ToDouble(inputUser);
                        checkInput = true;
                        Console.WriteLine($"Sie haben {value} Euro Guthaben\n");
                    }
                    else
                    {
                        Console.WriteLine("Bitte nur 5 oder 10 Euroscheine hinzufügen!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return value;
        }
        public static int GetIntInput(string input)
        {
            int value = 0;
            bool checkInput = false;
            while (!checkInput)
            {
                Console.WriteLine(input);
                string inputUser = Console.ReadLine();
                try
                {
                    {
                        value = Convert.ToInt32(inputUser);
                        checkInput = true;

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return value;
        }

    }

}




    

    
