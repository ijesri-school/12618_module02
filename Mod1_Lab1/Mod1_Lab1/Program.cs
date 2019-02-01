using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables of different data types and initialize with a "default" value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            // Assign some values
            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            street = "123 Fourth Street";
            city = "Anytown";
            country = "MyCountry";
            birthDate = new DateTime(1932, 6, 1);

            // Output to the consolw window

            // Use simple output with hjust variable names
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // Use placeholder style
            Console.WriteLine("{0} years old.", age);

            // Use string concatenation
            Console.WriteLine(street + ", " + city + ", " + country);

            // Use string interpolation
            Console.WriteLine($"Born on {birthDate}");

            Console.ReadKey();
        }
    }
}
