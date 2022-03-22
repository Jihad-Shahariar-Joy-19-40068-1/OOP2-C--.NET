using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_I_
{
    class Country
    {
        string[] cities = new string[3];
        //Indexer
        public string this[int index]
        {
            set { cities[index] = value; }
            get { return cities[index]; }
        }

        public int LengthOfCities
        {
            get { return cities.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();
            country[0] = "Dhaka";
            country[1] = "London";
            country[2] = "Jedda";
            //Console.WriteLine(country[0]);
            for(int i=0;i<country.LengthOfCities;i++)
            {
                Console.WriteLine(country[i]);
            }
        }
    }
}
