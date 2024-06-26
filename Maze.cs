using Figgle;
using GameTexts;

namespace Viktoras
{
    public class Maze
    {
        public static Movement.Player player = new(0, 1);
        public static bool playGame = true;
        public static void RunMaze()
        {
            DrawMaze.CreateMaze();

            ConsoleKey pressedKey;
            PopUpTexts.StartMenu();
            do
            {
                ConsoleKeyInfo enterInfo = Console.ReadKey();
                pressedKey = enterInfo.Key;
                PopUpTexts.StartMenu();
            } while (pressedKey != ConsoleKey.Enter);

            PopUpTexts.Instructions();
            do
            {
                ConsoleKeyInfo enterInfo = Console.ReadKey();
                pressedKey = enterInfo.Key;
                PopUpTexts.Instructions();
            } while (pressedKey != ConsoleKey.Enter);
            
            Countdown.StartCountDown();
            PopUpTexts.AddMessagesSDG();
            int previousPlayerX = player.X;
            int previuosPlayerY = player.Y;

            while (playGame)
            {
                Console.Clear();
                DrawMaze.Drawing();

                string playerSymbol = "P";
                Console.SetCursorPosition(player.X, player.Y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(playerSymbol);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                DrawMaze.mazeMap[player.Y, player.X] = "o";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                Movement.MazeMovement();

                string element = Movement.ElementInPlayerPosition(player.X, player.Y);
                // checking what is in the players way
                if (element == "X")
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    Countdown.timer.Stop();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    playGame = false;
                }
                if (element == "?")
                {
                    PopUpTexts.PrintMessageSDG();
                }

                if (element == "o")
                {
                    Console.SetCursorPosition(previousPlayerX, previuosPlayerY);
                    Console.Write(" ");
                    DrawMaze.mazeMap[previuosPlayerY, previousPlayerX] = " ";
                }
                previousPlayerX = player.X;
                previuosPlayerY = player.Y;
            }
        }
    }
}