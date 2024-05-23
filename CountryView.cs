using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryView
    {
        //properties
        public Country DisplayCountry {get; set; }

        //constructor

        public CountryView(Country displayCountry) 
        {   
            DisplayCountry = displayCountry;
            
        }

        //methods 
        public void Display()
        {
            if (DisplayCountry.Name == "France")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (DisplayCountry.Name == "Germany")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (DisplayCountry.Name == "Spain")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (DisplayCountry.Name == "Thailand")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ResetColor();
            }
            Console.WriteLine($"\nCountry: {DisplayCountry.Name} \nContinent: {DisplayCountry.Continent} \nColors: {string.Join(", ", DisplayCountry.Colors)}");
            Console.ForegroundColor= ConsoleColor.White;
            Console.BackgroundColor= ConsoleColor.Black;
        }
        
    }
}
