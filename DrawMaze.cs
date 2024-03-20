namespace Viktoras
{
    public class DrawMaze
    {
        public static string[] map = File.ReadAllLines("assets/ascii.txt");
        public static string[,]? mazeMap;
        public static int rows;
        public static int columns;
        public static void CreateMaze()
        {
            Console.Title = "Zemynas";
            rows = map.Length;
            columns = map[0].Length;
            mazeMap = new string[rows, columns];

            for (int r = 0; r < rows; ++r)// getting maze parts
            {
                string line = map[r];
                for (int c = 0; c < columns; ++c)
                {
                    char currentSymbol = line[c];
                    mazeMap[r, c] = currentSymbol.ToString();
                }
            }
        }
        public static void Drawing() //drawing maze to console
        {
                for (int y = 0; y < rows; y++)
                {
                    for (int x = 0; x < columns; x++)
                    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    string mazePart = mazeMap[y, x];
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    Console.SetCursorPosition(x, y);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        if (mazePart == "X")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        if (mazePart == "?")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(mazePart);
                    }
                }
        }

    }
}