using System;

namespace TemperatureConverter
{
    class Program
    {
        static void calculateFahrenheit() 
        {
            Console.WriteLine("Your choice: F");
            Console.WriteLine("Please enter the temperature in Celsius:");
            int celsius;

            while (!Int32.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Please enter a valid number");
            }

            int fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is {fahrenheit}");
        }

        static void calculateCelsius() 
        {
            Console.WriteLine("Your choice: C");
            Console.WriteLine("Please enter the temperature in Fahrenheit:");
            int fahrenheit;

            while (!Int32.TryParse(Console.ReadLine(), out fahrenheit))
            {
                Console.WriteLine("Please enter a valid number");
            }

            int celsius = (fahrenheit - 32) * (5 / 9);
            Console.WriteLine($"The temperature in Celsius is {celsius}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Temperature Converter!");
            Console.WriteLine("Hello! Today we're going to convert temperatures!");

            Console.WriteLine("Press C to convert from Fahrenheit to Celsius or Press F to convert from Celsius to Fahrenheit");
            string userChoice = Console.ReadLine().ToUpper();

            if (userChoice == "C")
            {
                calculateCelsius();

            }
            else 
            {
                calculateFahrenheit();
            }

        }
    }
}
