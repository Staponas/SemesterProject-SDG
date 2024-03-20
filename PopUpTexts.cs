using Figgle;

namespace Viktoras
{
    public class PopUpTexts
    {
        public static List<string> messages = new List<string>();
        public static int loopSDGMessages = 0;

        public static void AddMessagesSDG()
        {
            messages.Add(@"Sustainable Development Goal 7: 
Ensure access to affordable, reliable, sustainable and modern energy for all.");
            messages.Add(@"Energy is the dominant contributor to climate change, 
accounting for around 60 per cent of total global greenhouse gas emissions.");
            messages.Add(@"Since 1990, global emissions of CO2 have increased
by more than 46 per cent.");
            messages.Add(@"Bioenergy is the single largest renewable energy source today, 
providing 10% of world primary energy supply.");
            messages.Add(@"By 2030, ensure universal access to affordable, 
reliable and modern energy services.");
            messages.Add(@"By 2030, increase substantially the share of renewable energy 
in the global energy mix.");
            messages.Add(@"By 2030, double the global rate of
improvement in energy efficiency.");

            messages.Add(@"Globally, the number of people without access to electricity declined 
from 1.2 billion in 2010 to 733 million in 2020.");
        }
        public static void PrintMessageSDG()
        {
#pragma warning disable CS8602 
            Countdown.timer.Stop();
#pragma warning restore CS8602 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Beep();
            Console.WriteLine(messages[loopSDGMessages]);
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue the game");
            ConsoleKey enterKey;
            do
            {
                ConsoleKeyInfo enterInfo = Console.ReadKey();
                enterKey = enterInfo.Key;
                Console.Clear();
                Console.WriteLine(messages[loopSDGMessages]);
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue the game");
                Console.WriteLine($"You pressed {enterKey}. You need to press Enter to continue");
            } while (enterKey != ConsoleKey.Enter);
            loopSDGMessages++;
            Countdown.timer.Start();
        }
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("YYou have decided to leave the maze.");
            Console.WriteLine("Would you like to play again?");
        }

        public static void StartMenu()
        {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Thin.Render(" "));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(FiggleFonts.Term.Render("                                                  W e l c o m e  t o"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(FiggleFonts.DotMatrix.Render(" M A Z E"));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(FiggleFonts.Term.Render("               P r e s s  E n t e r  t o  c o n t i n u e"));
        }
        public static void Instructions()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(FiggleFonts.Term.Render("Welcome to the Electric Maze Adventure!\n"));
            Console.WriteLine(FiggleFonts.Term.Render(@"Your Mission: Connect the electricity cable 
 from the maze's starting point to the elusive red 'X'."));
            Console.WriteLine(FiggleFonts.Term.Render(@"The Cable: Trace your path with the symbol 'o',
 and watch the electrifying connection unfold!"));
            Console.WriteLine(FiggleFonts.Term.Render(@"Your Character: You are the intrepid symbol 'P',
 navigating the maze's twists and turns."));
            Console.WriteLine(FiggleFonts.Term.Render(@"Collect Clues: Keep an eye out for '?' symbols.
 They hold secrets about SDG 7 that you'll need for future!"));
            Console.WriteLine(FiggleFonts.Term.Render(@"Controls: Use the dynamic WASD keys to maneuver
 through the maze and overcome obstacles."));
            Console.WriteLine(FiggleFonts.Term.Render(@"Time Ticking Away: You have a limited 180 seconds to conquer the maze.
 Can you make it in time?"));
            Console.WriteLine(FiggleFonts.Term.Render(@"Embrace the Darkness: It's pitch-black in the maze. 
 Remember to pause for a moment to check the timer properly."));
            Console.WriteLine("Good luck, and may the currents be in your favor!\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FiggleFonts.Term.Render("Ready to Begin?: Press Enter to embark on this electrifying adventure!"));
        }
        public static void TimeEnds()
        {
            Console.Clear();
            Console.WriteLine(@"Your time is up, but workers of power station joined you so you can finish the maze safely!
            
Press any key and finish the maze!");
            Console.ReadKey();
        }


    }


}
