using System;

namespace LAB_3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = -1;
            string continueEntry = "y";

            while (!(userInput > 0 && userInput <= 100) && (continueEntry == "y"))
            {
                Console.WriteLine("Please enter a number between 1 to 100.");
                userInput = int.Parse(Console.ReadLine());

                if (!(userInput > 0 && userInput <= 100))
                {
                    Console.WriteLine("Invalid entry\n");
                    userInput = -1;                    
                }
                else if (userInput % 2 > 0 && userInput > 60)
                {
                    Console.WriteLine($"You entered {userInput} and it is an odd number.\n");
                    userInput = -1;
                    continueEntry = " ";
                }
                else if ((userInput % 2 == 0) && (userInput >= 2) && (userInput <= 25))
                {
                    Console.WriteLine($"You entered even number and it is less than 25.\n");
                    userInput = -1;
                    continueEntry = " ";
                }
                else if ((userInput % 2 == 0) && (userInput >= 26) && (userInput <= 60))
                {
                    Console.WriteLine($"You entered an even number.\n");
                    userInput = -1;
                    continueEntry = " ";
                }
                else if ((userInput % 2 == 0) && (userInput > 60))
                {
                    Console.WriteLine($"You entered {userInput} and it is an even number.\n");
                    userInput = -1;
                    continueEntry = " ";
                }
                else if ((userInput % 2 > 0) && (userInput < 60))
                {
                    Console.WriteLine($"You entered {userInput} and it is an odd number.\n");
                    userInput = -1;
                    continueEntry = " ";
                }
                else
                {
                    Console.WriteLine("Invalid entry\n");
                    userInput = -1;
                }

                while (continueEntry != "n" && continueEntry != "y")
                {
                    Console.WriteLine("Would you like to continue (y/n)?");
                    continueEntry = (Console.ReadLine().ToLower());
                    Console.WriteLine();

                    while (continueEntry != "n" && continueEntry != "y")
                    {
                        Console.WriteLine("Invalid entry, please enter (y/n).");
                        continueEntry = Console.ReadLine();
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Thank you for your time, goodbye!");
            Console.ReadKey();
        }

    }
}

