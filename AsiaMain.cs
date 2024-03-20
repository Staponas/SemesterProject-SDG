using System;
using System.Threading.Tasks.Sources;

namespace Ada
{
    class AsiaMain

    {
        public int score { get; set; }
        public void Result()
        {

            Console.WriteLine("Where you should throw a bottle?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? bottle = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (bottle == "plastic")
                {
                    score++;
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw leftovers?");
            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? eggshell = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                if (eggshell == "organic")
                {
                    score++;
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("incorrect");
                }

            }
            catch (Exception)
            {
                //catch
                Console.WriteLine("Null");
            }

            try
            {
                Console.WriteLine("Where you should throw cans?");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? can = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                if (can == "metal")
                {
                    score++;
                    Console.WriteLine("correct");
                }

                else
                {
                    Console.WriteLine("incorrect");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("null");
            }
            Console.WriteLine("Your score is {0}", score);
            // return  score;
            Console.WriteLine("Where you should throw a Plastic Bags?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? plasticBags = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (plasticBags == "plastic")
                {
                    score++;
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }

            Console.WriteLine("Where you should throw a caps?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? caps = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (caps == "plastic")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw zests?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? zests = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (zests == "organic")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }

            Console.WriteLine("Where you should throw flowers?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? flowers = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (flowers == "organic")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw paper notes?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? paperNotes = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (paperNotes == "paper")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw computer?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? computer = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (computer == "ewaste")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw leaflets?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? leaflets = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (leaflets == "paper")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }

            Console.WriteLine("Where you should throw diary?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? diary = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (diary == "paper")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw a mouse?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? mouse = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (mouse == "ewaste")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw books?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? books = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (books == "paper")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw a broken water glass ?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? brokenWaterGlass = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (brokenWaterGlass == "glass")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }
            Console.WriteLine("Where you should throw a keyboard?");

            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? keyboard = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (keyboard == "ewaste")
                {
                    score++;
                    Console.WriteLine("correct");

                }
                else
                {
                    Console.WriteLine("incorrect");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("You haven't enter answer.");
            }

            //achivement
            if (score >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Now you have to wait to recycle all your trash");
                Thread.Sleep(5710);
                Console.WriteLine("Its done. Your recycled trash turned into an achivement.");
                Console.WriteLine("Well Done. \r\n You recieve a tool \r\n ");
            }
            else
            {
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.WriteLine("\r\n Even if your result is on the simple side, get ready for a nifty tool.\r\n Thanks to it, you'll be able to combat the sneaky challenge and overcome the tricky stuff. This tool is your secret weapon against the villain!" );
             
                }  
        }
    }
}

