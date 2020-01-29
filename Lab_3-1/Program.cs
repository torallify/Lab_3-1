using System;

namespace Lab_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userContinue = null;
            int studentInt;
            bool worked;
            string userChoice = null;
            string name, dish, title;
            string learnMore;
            

            string[] studentNames = { "Laura", "Brea", "Lucero","Mike","Olaposi","Lauren", "Russ","Socrates","Tom", "Jacob" };
            string[] favoriteDish = { "Basil fried rice with no bell peppers. \nShe likes it with extra egg and chicken with medium+ spice",
                                        "Egg Noodles with no meat and EXTRA HOT spice",
                                        "tacos de lengua with extra salsa",
                                        "pad thai",
                                         "pizza",
                                         "chicken wings",
                                         "Sushi",
                                         "gyro",
                                         "vindaloo",
                                         "soup"};
            string[] previousTitle = { "Application Analyst",
                                        "Verification of Employment Specialist",
                                        "Executive Client Communication",
                                        "Data Analyst",
                                        "Professional Leg Model",
                                        "Princess",
                                        "Professional Box Smasher",
                                        "Philosopher",
                                        "Wizard",
                                        "Imports/Exports" };

            Console.Write("Welcome to our Dev.Build(3.0) Class.");

            do
            {
                
                Console.Write($"\nWhich student would you like to know about? (Enter a number from 1-{studentNames.Length}): ");

                string userInput = Console.ReadLine();
                worked = int.TryParse(userInput, out studentInt);

                if (worked == false)
                {
                    Console.WriteLine("That wasn't a number!");
                    Console.Write("Please try again: ");
                    userInput = Console.ReadLine();
                    worked = int.TryParse(userInput, out studentInt);
                }
                if (studentInt > studentNames.Length || studentInt <=0)
                {
                    Console.WriteLine($"\nThe number {studentInt} is not in the range");
                    Console.Write($"\nPlease enter a number between 1-{studentNames.Length}: ");
                    userInput = Console.ReadLine();
                    worked = int.TryParse(userInput, out studentInt);
                }

                name = studentNames[studentInt - 1];
                dish = favoriteDish[studentInt - 1];
                title = previousTitle[studentInt - 1];

                Console.WriteLine($"\nStudent {studentInt} is {name}. ");

                Console.Write($"\nWhat would you like to know about {name} (enter \"favorite dish\" or \"previous title\"): ");
                userChoice = Console.ReadLine().ToLower();

                while ((userChoice != "favorite dish") && (userChoice != "previous title"))
                {
                    Console.Write("\nInvalid input. Please enter \"favorite dish\" or \"previous title\"): ");
                    userChoice = Console.ReadLine().ToLower();
                }


                if (userChoice == "favorite dish")
                {
                    Console.WriteLine($"\n{name}'s {userChoice} is {dish}.");

                    Console.Write($"\nWould you like to know {name}'s previous title? (Enter \"yes\" or \"no\"): ");
                    learnMore = Console.ReadLine().ToLower();

                    if (learnMore == "yes")
                    {
                        Console.Write($"\n{name}'s previous title was {title}.");
                    }
                }
                else if (userChoice == "previous title")
                {
                    Console.WriteLine($"\n{name}'s {userChoice} was {title}.");

                    Console.Write($"\nWould you like to know {name}'s favorite dish? (Enter \"yes\" or \"no\"): ");
                    learnMore = Console.ReadLine().ToLower();

                    if (learnMore == "yes")
                    {
                        Console.WriteLine($"\n{name}'s favorite dish is {dish}.");
                    }
                }

                Console.Write("\nWould you like to know about another student? (Enter \"yes\" or \"no\"): ");
                userContinue = Console.ReadLine().ToLower();

                while ((userContinue != "yes") && (userContinue != "no" ))
                {
                    Console.Write("\nInvalid input. Please enter \"yes\" or \"no\"): ");
                    userContinue = Console.ReadLine().ToLower();
                }

                
            } while (userContinue == "yes");

            Console.WriteLine("\nThank you!");
        }
    }
}
