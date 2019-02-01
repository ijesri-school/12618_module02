using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BEGIN HELLO WORLD
            Console.WriteLine("----BEGIN HELLO WORLD----");
            Console.WriteLine();
            Console.WriteLine();

            string aFriend = "Bill";
            Console.WriteLine($"Hello {aFriend}");
            Console.WriteLine();

            aFriend = "Maira";
            Console.WriteLine($"Hello {aFriend}");
            Console.WriteLine();

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine();

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
            Console.WriteLine();

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
            Console.WriteLine();

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            Console.WriteLine();

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
            Console.WriteLine();

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine();
            
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine();

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
            Console.WriteLine();
            //END HELLO WORLD
            Console.WriteLine("-----END HELLO WORLD-----");
            Console.WriteLine();

            //BEGIN NUMBERS IN C#
            Console.WriteLine("----BEGIN NUMBERS IN C#----");
            Console.WriteLine();
            Console.WriteLine();

            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine();

            c = a - b;
            Console.WriteLine(c);
            Console.WriteLine();

            c = a * b;
            Console.WriteLine(c);
            Console.WriteLine();

            c = a / b;
            Console.WriteLine(c);
            Console.WriteLine();

            a = 5;
            b = 4;
            c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
            Console.WriteLine();

            a = 5;
            b = 4;
            c = 2;
            d = (a + b) * c;
            Console.WriteLine(d);
            Console.WriteLine();

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            Console.WriteLine();

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            Console.WriteLine(d);
            Console.WriteLine();

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            Console.WriteLine();

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            Console.WriteLine();

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
            Console.WriteLine();

            double aa = 5;
            double bb = 4;
            double cc = 2;
            double dd = (aa + bb) / cc;
            Console.WriteLine(dd);
            Console.WriteLine();

            aa = 19;
            bb = 23;
            cc = 8;
            dd = (aa + bb) / cc;
            Console.WriteLine(dd);
            Console.WriteLine();
        
            //END NUMBERS IN C#
            Console.WriteLine("-----END NUMBERS IN C#-----");
            Console.WriteLine();

            //BEGIN BRANCHES AND LOOPS
            Console.WriteLine("----BEGIN BRANCHES AND LOOPS----");
            Console.WriteLine();
            Console.WriteLine();

            a = 5;
            b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            Console.WriteLine();

            a = 5;
            b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine();

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            Console.WriteLine();

            // END BRANCHES AND LOOPS
            Console.WriteLine("-----END BRANCHES AND LOOPS-----");
            Console.WriteLine();

            //BEGIN LIST COLLECTION
            Console.WriteLine("----BEGIN LIST COLLECTION----");
            Console.WriteLine();
            Console.WriteLine();

            var names = new List<string> { "Ibrahim", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();

            //END LIST COLLECTION
            Console.WriteLine("-----END LIST COLLECTION-----");
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    

         /*   public BankAccount(string name, decimal initialBalance)
    {
        //BEGIN LIST COLLECTION
        Console.WriteLine("----BEGIN CLASSES AND OBJECTS----");
        Console.WriteLine();
        Console.WriteLine();


        this.Owner = name;
        this.Balance = initialBalance;
    }



    //END CLASSES AND OBJECTS
    Console.WriteLine("-----END CLASSES AND OBJECTS-----");
            Console.WriteLine();
            Console.WriteLine();

    */
}
