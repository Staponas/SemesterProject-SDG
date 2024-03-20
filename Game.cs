using System.Data;
using System.Security.Cryptography.X509Certificates;
using FishingSimulator;
using Ada;
using Viktoras;
using SemesterProjectAfrica;
using GameTexts;
using Figgle;
using System.Media;  

namespace InventorySystem
{

    public class Game
    {
        public string? location;
        private Room? currentRoom;
        public Inventory inventory = new();
        private int finalbattle;

        public Game()
        {
            CreateRooms();
        }

        private void CreateRooms()
        {
            Room? mainRoom = new("Your Home", " - Denmark");
            Room? maze = new("Maze", " - Europe");
            Room? farm = new("Food and calories", " - Africa");
            Room? hospital = new("Wellness Center", " - America");
            Room? recycleArea = new("Recycle Area", " - Asia");
            Room? fishingPond = new("Fishing Pond", " - Oceania");

            mainRoom.SetExits(null, maze, farm, hospital, recycleArea, fishingPond);

            //africa
            farm.SetExit("home", mainRoom);

            //europe
            maze.SetExit("home", mainRoom);

            //america
            hospital.SetExit("home", mainRoom);

            //asia
            recycleArea.SetExit("home", mainRoom);

            //oceania
            fishingPond.SetExit("home", mainRoom);

            currentRoom = mainRoom;

        }
        public void Play()
        {
            SoundPlayer gameMusic = new SoundPlayer();
            gameMusic.SoundLocation = "assets/instant-rave-69443.wav";
            gameMusic.PlayLooping();
            Console.Clear();
            Console.WriteLine(FiggleFonts.Starwars.Render("        Z E M Y N A S"));
            Console.WriteLine();
            Console.WriteLine("                         Press Enter to START the game");
            ContinueText();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            location = "home";

            Console.WriteLine("");
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("");
            Console.Write("You will be able to move between the continents by typing either 'europe', 'africa', 'america', ");
            Console.WriteLine("'asia', 'oceania' or 'home'.");
            Console.Write("Whenever you want to go from one continent to the other, you will have to go back ");
            Console.WriteLine("home first and then type the name of the continent you want to go to.");
            Console.WriteLine("");
            Console.WriteLine("Each continent has a minigame, to play this minigame simply type 'play'.");
            Console.WriteLine("Once you finish all the minigames you can move on to the final battle of your journey in ZEMYNAS");
            Console.WriteLine("by typing 'finalbattle'.");
            Console.WriteLine("You can also check your inventory by typing 'inventory'.");
            Console.WriteLine("Press Enter to continue your adventure");
            ContinueText();
            Console.Clear();
            Console.WriteLine("When you see '>' press enter to continue");
            Console.WriteLine();
            Console.WriteLine(@"It is a normal day just like any other, or at least it seems that way. You decide it is time to watch tv like you usually do, 
since you can’t come up with anything better to do right now.");
            Console.WriteLine(">");
            ContinueText();
            Console.WriteLine(@"As you turn on the tv you go through the different channels to see if anything interesting is on.");
            Console.WriteLine(">");
            ContinueText();
            Console.WriteLine(@"It then lands on the news, and even though it is not necessarily the most interesting thing to watch
it is still a good idea sometimes to stay informed about what is going on, so you decide to keep watching the news.");
            Console.WriteLine(">");
            ContinueText();
            Console.WriteLine(@"The news is unusual though, they seem to be talking about some mysterious creature that has shown up out of nowhere.");
            Console.WriteLine(">");
            ContinueText();  
            Console.WriteLine(@"On the screen you see a recording of a creature that is big enough to reach multiple continents at the same time. 
It has five long robotic arms that are similar to tentacles that seem to be placed on the five continents 
Africa, America, Asia, Europe, and Oceania. The tentacles are attached to what looks like a skull where the place
where there normally would be eyes there are these red glowing orbs that are difficult to tell if its lights or actual eyes.  ");
            Console.WriteLine(">");
            ContinueText();  
            Console.WriteLine(@"The news then continues to talk about some issues at hand.  ");
            Console.WriteLine(">");
            ContinueText(); 
            Console.WriteLine(@"As a consequence of the appearance of this alien creature, the five continents 
Africa, America, Asia, Europe and Oceania are experiencing unusual circumstances.  ");
            Console.WriteLine(">");
            ContinueText(); 
            Console.WriteLine(@"In Africa they are having a hard time getting enough food and a lot of people are at the risk of starving to death, 
with a lot of people having already died from starvation. ");
            Console.WriteLine(">");
            ContinueText(); 
            Console.WriteLine(@"In America they are struggling with running their health center and the lives of the people are in danger. ");
            Console.WriteLine(">");
            ContinueText(); 
            Console.WriteLine(@"In Asia trash is starting to overflow the streets, and it is reaching a point of potentially making some animals go extinct from pollution,
as well as the planet is at risk of running out of natural resources. ");
            Console.WriteLine(">");
            ContinueText(); 
            Console.WriteLine(@"In Europe the necessary resources for the power supplies are running low, and a lot of the cables connected to different power stations are broken.
Which then has resulted in Europe struggling to supply its people with the electricity they require and demand.");
            Console.WriteLine(">");
            ContinueText(); 
            Console.WriteLine(@"In Oceania there are issues of fish and other animals in the surrounding ocean going extinct, and this has resulted in a disturbance in the ocean's ecosystem.
It has also caused a lower amount of food since fishing has become a lot more difficult with less fish in the ocean.");
            Console.WriteLine(">");
            ContinueText(); 
            Console.WriteLine(@"With everything going on multiple countries are trying to investigate potential solutions, 
but it is uncertain when or if any of the issues are going to be solved. ");
            Console.WriteLine(">");
            ContinueText(); 
            Console.WriteLine(@"The news report ends there, and you reflect over what you just heard for a bit, thinking what could this creature want? And what about all those problems
those continents were experiencing, is there anything you could do to help? ");
            Console.WriteLine(">");
            ContinueText(); 
            while(true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.Write("It is now up to you; Will you go out there and help solve the ");
                Console.WriteLine("current problems?");
                Console.WriteLine("");
                Console.WriteLine("(Answer with yes/no)");
                Console.WriteLine("");

                string? answer = Console.ReadLine();
                if(answer != null && answer.ToLower().Equals("no")){
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("I see that you have chosen to not take responsibility, sorry to see you go:((");
                    Console.WriteLine("");
                    Environment.Exit(0);
                    
                }
                else if(answer != null && answer.ToLower().Equals("yes")){
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input, try again.");
                }

            }
            //Console.WriteLine(@"");
            ContinueText(); 
            Console.Clear();
            


            bool continuePlaying = true;
            while (continuePlaying)
            {
                Console.WriteLine("");
                Console.Write(currentRoom?.ShortDescription);
                Console.WriteLine(currentRoom?.Continent);
                Console.WriteLine("");

                string? input = Console.ReadLine();
                Console.WriteLine("");

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a command.");
                    continue;
                }

                input = input.ToLower();


                switch (input)
                {
                    case "home":
                    case "africa":
                    case "america":
                    case "asia":
                    case "europe":
                    case "oceania":
                        if (inventory.Items?.Count == 5)
                        {
                            Console.WriteLine("With all the minigames complete you can move on to your final battle.\nType \"finalbattle\" to start the boss battle");
                        }
                        Move(input);
                        location = input;
                        break;
                    case "inventory":
                        Console.WriteLine("Inventory:");
                        inventory.Display();
                        Console.WriteLine("");
                        break;
                    case "exit":
                        continuePlaying = false;
                        break;
                    case "play":
                        if (location == "europe")
                        {
                            if (inventory.CheckForDevicePartEurope())
                            {
                                Console.WriteLine("You have already completed the minigame");
                            }
                            else
                            {
                                Story.StartEurope();
                                Maze.RunMaze();
                                inventory.Add("devicePartEurope");
                                Console.ResetColor();
                                Story.EndEurope();

                            }
                        }
                        if (location == "africa")
                        {
                            if (inventory.CheckForDevicePartAfrica())
                            {
                                Console.WriteLine("You have already completed the minigame");
                            }
                            else
                            {
                                Story.StartAfrica();
                                Africa.RunAfrica();
                                inventory.Add("devicePartAfrica");
                                Console.ResetColor();
                                Story.EndAfrica();
                            }
                        }
                        else if (location == "america")
                        {

                            if (inventory.CheckForDevicePartAmerica())
                            {
                                Console.WriteLine("You have already completed the minigame");
                            }
                            else
                            {
                                Story.StartAmerica();
                                WellnessCenter.WellnessCenterRun();
                                inventory.Add("devicePartAmerica");
                                Console.ResetColor();
                                Story.EndAmerica();
                            }
                        }
                        else if (location == "asia")
                        {

                            if (inventory.CheckForDevicePartAsia())
                            {
                                Console.WriteLine("You have already completed the minigame");
                            }
                            else
                            {
                                Story.StartAsia();
                                StartAsia.StartRecycling();
                                inventory.Add("devicePartAsia");
                                Console.ResetColor();
                                Story.EndAsia();
                            }
                        }
                        else if (location == "oceania")
                        {

                            if (inventory.CheckForDevicePartOceania())
                            {
                                Console.WriteLine("You have already completed the minigame");
                            }
                            else
                            {
                                Story.StartOceania();
                                Fishing.FishingGame();
                                inventory.Add("devicePartOceania");
                                Console.ResetColor();
                                Story.EndOceania();
                            }
                        }
                        break;
                    case "finalbattle":
                        if (inventory.Items?.Count != 5)
                        {
                            Console.WriteLine("You have not yet obtained all the items to battle the entity");
                            Console.WriteLine("Complete all the minigames first");
                            break;
                        }
                        Story.StartFinalBoss();
                        BossFight.RunBattle();
                        Story.EndFinalBoss(); 
                        break;
                    default:
                        Console.WriteLine("I don't know that input");
                        break;
                }
            }
            //gameMusic.Stop();

            Console.WriteLine("Thank you for playing the game!");

        }
        private void Move(string direction)
        {
            if (currentRoom?.Exits.ContainsKey(direction) == true)
            {
                currentRoom = currentRoom?.Exits[direction];
            }
            else
            {
                Console.WriteLine($"You can't go to {direction}!");
            }
        }
        static void ContinueText()
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
            }
        }
    }
}
