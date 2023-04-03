using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTUAL_Tietokoneet_Ja_Tilat_Harjoitus_LINQ
{
    #region PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TIETOKONE- JA TILAREKISTERI";

            bool mainMenuActive = true;
            while (mainMenuActive)
            {
                mainMenuActive = MainMenu();
            }

            
        }
        #endregion
        #region READ -> COMPUTERS
        private static void ReadCsvFile()
        {
            Console.Clear();
            var csvFileDescription = new CsvFileDescription
            {
                // ASETUKSET

                FirstLineHasColumnNames = true, //eka rivi on nimet sarakkeille
                IgnoreUnknownColumns = true, // skippaa kirjaamattomat rivit
                SeparatorChar = ',', //erottajamerkki
                UseFieldIndexForReadingData = true,



            };

            var csvContext = new CsvContext(); //Luodaan uusi konteksti
            var tietokoneet = csvContext.Read<Tietokoneet>("Tietokoneet.csv", csvFileDescription);
            //Annetaan käsky lukea tiedostoa antamilla ehdoilla "csvFileDescription"


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Formaatti");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|ID/Merkki/Malli/Omistussuhde/Huone ID|");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________________________________________________________________________");
            Console.ResetColor();

            foreach (var tietokone in tietokoneet) //Anetaan käsky jokaiselle arvolle tiedostossa
            {
                Console.WriteLine($"{ tietokone.TietokoneID}, {tietokone.Merkki}, {tietokone.Malli}, {tietokone.Omistussuhde}, {tietokone.Huone}");

            }
            Console.ForegroundColor = ConsoleColor.DarkBlue; 
            Console.WriteLine("________________________________________________________________________");
            Console.ResetColor();
        }
        #endregion

        #region MAIN MENU
        private static bool MainMenu()
        {

            string[] mainMenuFunctions =
            {
                "                                                                                ",
                " |(L)|Listaa tietokoneet (Tietokoneet.CSV) |(T)|Listaa tilat (Tilat.CSV) ____   ",
                " |(M)|- Muokkaa tietokonetta               |(X)|- Muokkaa tilaa         ||  ||  ", 
                " |(P)|- Poista tietokone                   |(V)|- Poista tila           ||__||  ",
                " |(O)|- Lisää tietokone                    |(A)|- Lisää tila            [ -=.]  ",
                " |   |_____________________________________|   |                        ======  ",
                " |(Q)|- Lopeta"};

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Valitse toiminto:");
            Console.ResetColor();

            foreach (string menuFunctionsList in mainMenuFunctions)
            {
                Console.WriteLine(menuFunctionsList);
            }

            switch (Console.ReadLine())
            {
                case "L":
                case "l":
                    ReadCsvFile();
                    return true;
                case "o":
                case "O":
                    AddComputer();
                    return true;
                case "Q":
                case "q":
                    return false;
                default:
                    return true;
            }

        }
        #endregion
        private static void AddComputer()
        {
            string[] errormessages = {"VIRHE: Antamasi arvo oli tyhjä.", "Tuntematon virhe. Jokin meni vikaan. Yritä uudelleen." };
            string[] successmessages = {"- arvo lisättiin onnistuneesti..." , "palautettiin onnistuneesti..."};
            // [0], [1]

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Anna sovellukseen seuraavat arvot:");
            Console.ResetColor();

            bool computerID_request = true;
            int computerID_min = 1;
            int computerID_max = 9999;
            int computerID;
            int computerID_input;

            while (computerID_request)
            {
                Console.WriteLine("Anna tietokoneen ID:");

                computerID_input = Convert.ToInt16(Console.ReadLine());

            if (computerID_input >= computerID_min && computerID_input <= computerID_max && computerID_input != 0)
            {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(computerID_input + " " + successmessages[0]);
                    Console.ResetColor();
                    computerID = computerID_input;
                    computerID_request = false;
                
            }
            else
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errormessages[0] + "\n" + "Tai " + errormessages[1]);
                    Console.ResetColor();
            }
                bool computerBrand_request = true;
                string computerBrand;
                string computerBrand_input;

                while (computerBrand_request)
                {
                    Console.WriteLine("Anna tietokoneen malli:");

                    computerBrand_input = Console.ReadLine();

                    if (String.IsNullOrEmpty(computerBrand_input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errormessages[0] + "\n" + "Tai " + errormessages[1]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(computerBrand_input + " " + successmessages[0]);
                        computerBrand_request = false;
                        Console.ResetColor();
                        computerBrand = computerBrand_input;

                    }
                }


                }
            bool computerModel_request = true;
            string computerModel;
            string computerModel_input;

            while (computerModel_request)
            {
                Console.WriteLine("Anna tietokoneen malli:");

                computerModel_input = Console.ReadLine();

                if (String.IsNullOrEmpty(computerModel_input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errormessages[0] + "\n" + "Tai " + errormessages[1]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(computerModel_input + " " + successmessages[0]);
                    computerModel_request = false;
                    Console.ResetColor();
                    computerModel = computerModel_input;

                }






            }
        }
    }
}

