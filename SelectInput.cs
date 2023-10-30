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
                    if (inputUser == "0,10" || inputUser == "0,20" || inputUser == "0,50" || inputUser == "1" ||
                        inputUser == "2" || inputUser == "5" || inputUser == "10")
                    {
                        value = Convert.ToDouble(inputUser);
                        checkInput = true;
                        Console.WriteLine($"Sie haben {value} Euro eingeworfen\n");
                    }
                    else
                    {
                        Console.WriteLine("Bitte nur 0,10, 0,20, 0,50, 1, 2, 5 oder 10 Münzen/Euroscheine hinzufügen!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return value;
        }

        public static string GetInput(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
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


