using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.Write("Write Your Name : ");
            string name = System.Console.ReadLine();

            System.Console.Write("Write Your ID : ");
            string id = System.Console.ReadLine();

            System.Console.Write("Write Your Semister : ");
            string semister = System.Console.ReadLine();

            System.Console.Write("Write Your CGPA : ");
            string cgpa = System.Console.ReadLine();

            System.Console.WriteLine("\nYou have Written: \nName: " + name);
            System.Console.WriteLine("\nID: " + id);
            System.Console.WriteLine("\nSemister: " + semister);
            System.Console.WriteLine("\nCGPA: " + cgpa);

        }
    }
}
