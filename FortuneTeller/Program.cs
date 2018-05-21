using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            string firstName;
            string lastName;
            int age;
            int remainder;
            bool isEven;
            string retirement;
            int month;
            string money;
            string color;
            string transportation = " ";
            int siblings;
            string location;

            // What is your first name?
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            // What is your last name?
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            // What is your age?
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            remainder = age % 2;
            isEven = remainder == 0;

            if (isEven == true)
            {
                retirement = "10 years";
            }
            else
            {
                retirement = "30 years";
            }

            // What is your birth month?
            Console.WriteLine("What is your birth month?");
            month = int.Parse(Console.ReadLine());

            if ((month >= 1) && (month <= 4))
            {
                money = "$5,000.00";
            }
            else if ((month >= 5) && (month <= 8))
            {
                money = "$50,000.00";
            }
            else if ((month >=9) && (month <= 12))
            {
                money = "$500,000.00";
            }
            else
            {
                money = "$0.00";
            }

            // What is your favorite color?
            Console.WriteLine("What is your favorite color from the ROYGBIV spectrum?");
            color = Console.ReadLine().ToLower();

            switch (color)
            {
                case "red":
                case "r":
                    transportation = "Lexus";
                    break;
                case "orange":
                case "o":
                    transportation = "Corvette";
                    break;
                case "yellow":
                case "y":
                    transportation = "Toyota";
                    break;
                case "green":
                case "g":
                    transportation = "Honda";
                    break;
                case "blue":
                case "b":
                    transportation = "Range Rover";
                    break;
                case "indigo":
                case "i":
                    transportation = "Jeep";
                    break;
                case "violet":
                case "v":
                    transportation = "BMW";
                    break;
                case "help":
                    Console.WriteLine("Please choose one of the following colors: Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    color = Console.ReadLine().ToLower();
                    switch (color)
                    {
                        case "red":
                        case "r":
                            transportation = "Lexus";
                            break;
                        case "orange":
                        case "o":
                            transportation = "Corvette";
                            break;
                        case "yellow":
                        case "y":
                            transportation = "Toyota";
                            break;
                        case "green":
                        case "g":
                            transportation = "Honda";
                            break;
                        case "blue":
                        case "b":
                            transportation = "Range Rover";
                            break;
                        case "indigo":
                        case "i":
                            transportation = "Jeep";
                            break;
                        case "violet":
                        case "v":
                            transportation = "BMW";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            // How many siblings do you have?
            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());

            if (siblings < 0)
            {
                location = "Cleveland";
            }
            else if (siblings == 0)
            {
                location = "Paris";
            }
            else if (siblings == 1)
            {
                location = "Cancun";
            }
            else if (siblings == 2)
            {
                location = "Rome";
            }
            else if (siblings == 3)
            {
                location = "London";
            }
            else
            {
                location = "Bali";
            }

            Console.WriteLine("{0} {1} will retire in {2} with {3} in the bank, a vacation home in {4}, and a {5}.", firstName, lastName, retirement, money, location, transportation);
            
        }
    }
}
