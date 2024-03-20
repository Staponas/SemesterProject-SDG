using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
namespace Ada
{
    internal class StartAsia
    {
        public static void StartRecycling()
        {
            Greeting();
            Thread.Sleep(0700);
            Logo();
            Thread.Sleep(0700);


            Console.Write("Its : ");
            Thread.Sleep(0700);

            Console.WriteLine(DateTime.Now.ToString("MMMM dd"));
            Thread.Sleep(0700);
            Console.Write("\r\nYou still have time to save the world.");

            
            Rules();
            Yes();

            Advice();
            Thread.Sleep(7000);

            Trash details = new Trash();
            Trash.SmartRecycling();
            Thread.Sleep(7000);

            

            AsiaMain game = new AsiaMain();
            game.Result();
            Thread.Sleep(5000);
            // after sorting game
            


            Finish();
            //come back to "couch room"
        }

        private static void Logo()
        {
            Console.WriteLine("\r\n");
            //Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(@"
     _    ____ ___    _    
    / \  / ___|_ _|  / \   
   / _ \ \___ \| |  / _ \  
  / ___ \ ___) | | / ___ \ 
 /_/   \_\____/___/_/   \_\
                           ");
        }
        private static void Greeting()
        {
            Console.WriteLine("Hello, Welcome in ...");
        }
        private static void Yes()
        {
            while(true)
            {
                Console.WriteLine("Please enter yes if you are ready:");
                string yesInput = Console.ReadLine().ToLower().Trim();
                if (yesInput.ToLower() == "yes")
                {
                    
                    break;
                }
            }
        }
        private static void Rules()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\nRules = you have to sort trash to correct bin.");

        }


        private static void Advice()
        {
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Before game you should read advice");
            Thread.Sleep(0777);
            Console.WriteLine("Here is a list of where to throw appropriate waste.");
            // I will upload more hints later
            Console.WriteLine("Organic waste: food waste, grass, leaves, eggshells, coffee grinds, tea bags." +
                "\r\nGlass: white and colored glass." +
                "\r\nPlastic/metal: plastic bottles, plastic packages, jars, cans." +
                "\r\nPaper: cardboard, paper bags, paper cups, paper." +
                "\r\nE-waste: printer , computer, smartphone.\r\n");

        }     
        private static void Finish()
        { 
        Console.WriteLine("Thank you for that mini-game...");
        Console.WriteLine("You are one step closer to defeat the villian.");
        }
        //not mine part
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }




    }
}
