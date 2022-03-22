using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakupLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Dhaka", "Barisal", "Chittagong", "Rajshahi", "Shylhet" };
            Console.WriteLine("Enter a city name: ");
            String city = Console.ReadLine();

            foreach (string element in cities)
            {
                if (element == city)
                {
                    Console.WriteLine(city + " exists");
                    break;
                }
                else
                {
                    Console.WriteLine(city + " does not exists");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
