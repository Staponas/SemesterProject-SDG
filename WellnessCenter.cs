using System;
using System.IO;

class WellnessCenter
{
    public static void WellnessCenterRun()
    {
        string previousAction = null; // Track the previous action
        string previousIncome = null; // Track the previous income action

        int visitorSatisfaction = 30;
        int budget = 150;
        int winningSatisfaction = 100;

        Console.WriteLine("Welcome to the Wellness Center Minigame! Where you have to make sure that the visitors reach maximum satisfaction");
        Console.WriteLine("Visitor Satisfaction: " + visitorSatisfaction);
        Console.WriteLine("Budget: $" + budget);

        string[] randomFacts = ReadRandomFactsFromFile("assets/RandomFacts.txt");

        Random random = new Random();

        while (visitorSatisfaction > 0 && budget >= 0 && visitorSatisfaction < winningSatisfaction)
        {
            Console.WriteLine("\nChoose your action:");
            Console.WriteLine("1. Conduct a fitness class (Cost: $100)");
            Console.WriteLine("2. Organize a mental wellness seminar (Cost: $70)");
            Console.WriteLine("3. Hire a nutrition expert for counseling (Cost: $50)");
            Console.WriteLine("4. Host a paid workshop (Income: $100)");
            Console.WriteLine("5. Sell wellness products (Income: $50)");
            Console.WriteLine("6. Take a short break (Cost: $0)");

            string userInput = Console.ReadLine();    

            // Check if the current action is the same as the previous one
            if (userInput == previousAction)
            {
                // Customize messages and adjust satisfaction penalty
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Too much exercise is not good for visitors' well-being!");
                        visitorSatisfaction -= 20; // Adjust the satisfaction penalty
                        break;
                    case "2":
                        Console.WriteLine("Another mental wellness seminar so soon might be overwhelming for visitors!");
                        visitorSatisfaction -= 15; // Adjust the satisfaction penalty
                        break;
                    case "3":
                        Console.WriteLine("Constant nutrition counseling may reduce the appeal for visitors!");
                        visitorSatisfaction -= 10; // Adjust the satisfaction penalty
                        break;
                    case "4":
                        Console.WriteLine("Repeating paid workshops consecutively reduces visitor satisfaction!");
                        visitorSatisfaction -= 15; // Adjust the satisfaction penalty
                        break;
                    case "5":
                        Console.WriteLine("Repeating selling wellness products consecutively reduces visitor satisfaction!");
                        visitorSatisfaction -= 10; // Adjust the satisfaction penalty
                        break;
                    case "6":
                        Console.WriteLine("Taking breaks too frequently may impact the visitors' overall experience!");
                        visitorSatisfaction -= 10; // Adjust the satisfaction penalty
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }
            }
            else
            {
                // Process the chosen action only if it's different from the previous one
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("You conducted a fitness class. Visitors feel invigorated!");
                        visitorSatisfaction += 10;
                        budget -= 100;
                        break;
                    case "2":
                        Console.WriteLine("You organized a mental wellness seminar. Visitors gain valuable insights!");
                        visitorSatisfaction += 5;
                        budget -= 70;
                        break;
                    case "3":
                        Console.WriteLine("You hired a nutrition expert for counseling. Visitors appreciate the expertise!");
                        visitorSatisfaction += 5;
                        budget -= 50;
                        break;
                    case "4":
                        if(previousIncome == userInput)
                        {
                            Console.WriteLine("Hosting a paid workshop too soon after the last time has impacted the wellness center's earnings. Visitor satisfaction is slightly reduced, and the center earned less income!");
                            budget += 40;
                            visitorSatisfaction -= 5;
                        }
                        else
                        {
                            Console.WriteLine("You hosted a paid workshop. The wellness center earned income!");
                            budget += 80;
                        }
                        break;
                    case "5":
                        if(previousIncome == userInput)
                        {
                            Console.WriteLine("Selling wellness products too soon after the last time has impacted the wellness center's earnings. Visitor satisfaction is slightly reduced, and the center earned less income!");
                            budget += 25;
                            visitorSatisfaction -= 5;
                        }
                        else
                        {
                            Console.WriteLine("You sold wellness products. The wellness center earned income!");
                            budget += 50;
                        }
                        break;
                    case "6":
                        Console.WriteLine("You decided to take a short break. Balance is important.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }

                Console.WriteLine("\n*** Random Fact: " + GetRandomFact(randomFacts) + " ***\n");

                if (random.Next(3) == 0)
                {
                    Console.WriteLine("*** Financial setback: Unexpected expenses! ***\n");
                    budget -= 50;
                }
            }

            // Ensure levels are within bounds [0, 100] and budget is not negative
            visitorSatisfaction = Math.Max(0, Math.Min(100, visitorSatisfaction));
            budget = Math.Max(0, budget);

            Console.WriteLine("Visitor Satisfaction: " + visitorSatisfaction);
            Console.WriteLine("Budget: $" + budget);

            // Prompt user to press Enter to continue
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // Update the previous action for the next iteration
            previousAction = userInput;

            // Check if the user input is an income action and update the previousIncome
            if(userInput == "5" || userInput == "6")
            {
                previousIncome = userInput;
            }
        }

        if (visitorSatisfaction >= winningSatisfaction)
        {
            Console.WriteLine("Congratulations! You've achieved the target visitor satisfaction. You win!");
        }
        else
        {
            if (budget <= 0)
            {
                Console.WriteLine("Out of budget! Game over.");
            }
            else
            {
                Console.WriteLine("Game over. The Wellness Center's health reached 0.");
                
            }
        }
    }

    // Method to get a random fact from the array
    static string GetRandomFact(string[] facts)
    {
        Random random = new Random();
        int index = random.Next(facts.Length);
        return facts[index];
    }

    // Method to read random facts from a text file
    static string[] ReadRandomFactsFromFile(string filePath)
    {
        try
        {
            return File.ReadAllLines(filePath);
        }
        catch (IOException e)
        {
            return Array.Empty<string>(); // Return an empty array in case of an error
        }
    }
}
