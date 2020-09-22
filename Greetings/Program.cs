using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            // You specify the initial value in a constant
            // If you change it later, that's an error
            //const string name = "luis";

            // Variable declaration with initial value
            // You can use "var" to replace the specific data type
            // but it is the same data type as the initial value
            // it is a "shortcut"
            var name = string.Empty;
            var birthDate = DateTime.Now;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("When is your birthday?");
            //birthDate = DateTime.Parse(Console.ReadLine());
            // Parse is ok, but we can use TryParse to validate the value that is written in the Console

            /* 
             * TryParse "returns" two values:
                * a boolean that indicates if the conversion is successful or not
                * the value converted -that's the out parameter-
            */
            if (DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                // Calculating the difference between two dates (today and birthday)
                // Difference is obtained in days (double), divide by 365 to find the age
                // Cast (convert) the value to int
                // The variable years has a block scope. It won't be accessible outside of the true block
                var years = (int)(DateTime.Now.Subtract(birthDate).TotalDays / 365);

                Console.WriteLine("Hello " + name + ", you are " + years + " years old");

                // Another way to print the message
                //Console.WriteLine($"Hello {name}, you are {years} years old");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Hello " + name + ", I can't tell your age");
            }

            // years = 10
            // years is not valid here because of scope
        }
    }
}