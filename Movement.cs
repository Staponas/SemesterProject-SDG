using Viktoras;

namespace Viktoras
{
    public class Movement
    {
        public struct Player
        {
            public int X;
            public int Y;
            public Player(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        public static string ElementInPlayerPosition(int x, int y)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return DrawMaze.mazeMap[y, x];
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        public static bool CheckPlayerPosition(int x, int y)
        {
            if (x < 0 || y < 0 || x >= DrawMaze.columns || y >= DrawMaze.rows)
                return false;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return DrawMaze.mazeMap[y, x] == " " || DrawMaze.mazeMap[y, x] == "X"
            || DrawMaze.mazeMap[y, x] == "?" || DrawMaze.mazeMap[y, x] == "o";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        public static void MazeMovement()// player movement
        {
            ConsoleKey pressedKey;
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                pressedKey = keyInfo.Key;

            } while (Console.KeyAvailable);

            if (pressedKey == ConsoleKey.W)
            {
                if (CheckPlayerPosition(Maze.player.X, Maze.player.Y - 1))
                {
                    Maze.player.Y--;

                }
            }
            if (pressedKey == ConsoleKey.S)
            {
                if (CheckPlayerPosition(Maze.player.X, Maze.player.Y + 1))
                {
                    Maze.player.Y++;
                }
            }
            if (pressedKey == ConsoleKey.A)
            {
                if (CheckPlayerPosition(Maze.player.X - 1, Maze.player.Y))
                {
                    Maze.player.X--;
                }
            }
            if (pressedKey == ConsoleKey.D)
            {
                if (CheckPlayerPosition(Maze.player.X + 1, Maze.player.Y))
                {
                    Maze.player.X++;
                }
            }
        }
    }
}