using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryController
    {
        //properties
        List<Country> CountryDb = new List<Country>
        {
            new Country ("France", "Europe",new List<string>(){"white","blue" }),
            new Country ("Germany", "Europe",new List<string>(){"yellow","black","red"}),
            new Country ("Spain", "Europe",new List<string>(){"red","gold" }),
            new Country ("Thailand", "Asia",new List<string>(){"blue","white","red" }),
        };

        //constructor
        //public CountryController(List<Country> _countryDb)
        //{
        //    CountryDb = _countryDb;
        //}

        public void CountryAction(Country c)
        {
            CountryView countryview = new CountryView(c);
            countryview.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countryListView = new CountryListView(CountryDb);
            Console.WriteLine($"Hello, welcome to the country app. Please select a country from the following list:");
            countryListView.Display();
            int index = int.Parse(Console.ReadLine());
            Country selectedCountry = CountryDb[index];
            for (int i = 0; i < CountryDb.Count; i++)
            {
                if(i == index)
                {
                    CountryAction(selectedCountry);
                }
            }
        }



    }
}
