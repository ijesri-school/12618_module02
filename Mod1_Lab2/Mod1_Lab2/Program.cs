using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and assign empty values
            // -- Student Information --
            string stuFirstName = "";
            string stuLastName = "";
            DateTime stuBirthDate;
            string stuAddressOne = "";
            string stuAddressTwo = "";
            string stuCity = "";
            string stuProvince = "";
            string stuPostal = ""; // Use a string because some countries use letters in their postal system
            string stuCountry = "";
            // -- Teacher Information --
            string tchFirstName = "";
            string tchLastName = "";
            DateTime tchBirthDate;
            string tchAddressOne = "";
            string tchAddressTwo = "";
            string tchCity = "";
            string tchProvince = "";
            string tchPostal = ""; // Use a string because some countries use letters in their postal system
            string tchCountry = "";
            // -- Program Information --
            string programName = "";
            string departmentHead = "";
            string degrees = "";
            // -- Degree Information --
            string degreeName = "";
            int creditsRequired = 0;
            // -- Course Information --
            string courseName = "";
            int courseCredits = 0;
            int courseDuration = 0;
            string courseTeacher = "";


            // Assign variables
            // -- Student Information --
            stuFirstName = "Ibrahim";
            stuLastName = "Jesri";
            stuBirthDate = new DateTime(2000, 6, 8);
            stuAddressOne = "211 N. Andover Rd.";
            stuAddressTwo = "Unit #222";
            stuCity = "Andover";
            stuProvince = "Kansas";
            stuPostal = "67002"; // Use a string because some countries use letters in their postal system
            stuCountry = "United States of America";
            // -- Teacher Information --
            tchFirstName = "Robert";
            tchLastName = "Ray";
            tchBirthDate = new DateTime(1979, 5, 4);
            tchAddressOne = "9201 W. Harvest Lane";
            tchAddressTwo = string.Empty;
            tchCity = "Wichita";
            tchProvince = "Kansas";
            tchPostal = "67212"; 
            tchCountry = "United States of America";
            // -- Program Information --
            programName = "Software Development";
            departmentHead = "Darryl Runyan";
            degrees = "Software Development (AAS)";
            // -- Degree Information --
            degreeName = "Software Development (AAS)";
            creditsRequired = 60;
            // -- Course Information --
            courseName = "Advanced C#";
            courseCredits = 3;
            courseDuration = 16;
            courseTeacher = "Robert Ray";


            // Output to console
            // -- Student Information --
            Console.WriteLine("---Student Information----");
            Console.WriteLine($"First Name: {stuFirstName}");
            Console.WriteLine($"Last Name: {stuLastName}");
            Console.WriteLine($"Born on: {stuBirthDate}");
            Console.WriteLine($"Address: {stuAddressOne}");
            Console.WriteLine(stuAddressTwo);
            Console.WriteLine(stuCity + ", " + stuProvince + ", " + stuPostal + ", " + stuCountry);
            Console.WriteLine();
            // -- Teacher Information --
            Console.WriteLine("---Teacher Information----");
            Console.WriteLine($"First Name: {tchFirstName}");
            Console.WriteLine($"Last Name: {tchLastName}");
            Console.WriteLine($"Born on: {tchBirthDate}");
            Console.WriteLine($"Address: {tchAddressOne}");
            Console.WriteLine(tchAddressTwo);
            Console.WriteLine(tchCity + ", " + tchProvince + ", " + tchPostal + ", " + tchCountry);
            Console.WriteLine();
            // -- Program Information --
            Console.WriteLine("---Program Information----");
            Console.WriteLine($"Program Name: {programName}");
            Console.WriteLine($"Department Head: {departmentHead}");
            Console.WriteLine($"Degree: {degrees}");
            Console.WriteLine();
            // -- Degree Information --
            Console.WriteLine("---Degree Information----");
            Console.WriteLine($"Degree Name: {degreeName}");
            Console.WriteLine($"Credits Required: {creditsRequired}");
            Console.WriteLine();
            // -- Course Information --
            Console.WriteLine("---Course Information----");
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Credits Required: {courseCredits}");
            Console.WriteLine($"Course Duration: {courseDuration}");
            Console.WriteLine($"Course Teacher: {courseTeacher}");


            // Keep Console Open
            Console.ReadKey();
        }
    }
}
