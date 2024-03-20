using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace FishingSimulator {

public class Fish
{
    public Fish(string name, string description, int weight, int rarity, int difficulty, bool isEdible)
    {
        Name = name;
        Description = description;
        Weight = weight;
        Rarity = rarity;
        Difficulty = difficulty;
        IsEdible = isEdible;
    }

    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Weight { get; set; }
    public int Rarity { get; set; }
    public int Difficulty { get; set; }
    public bool IsEdible { get; set; }
}

public class Sea
{
    public Sea()
    {
        Fishes = new List<Fish>();
    }

    public List<Fish> Fishes { get; set; }
}

public class CBuffer
{
    public static void ClearBuffer()
    {
        while (Console.KeyAvailable) Console.ReadKey(true);
    }
}

public class Fishing
{
    private static readonly Sea _sea = new(); //new instance of Sea class
    private static readonly Random _random = new(Guid.NewGuid().GetHashCode()); //new instance of random
    private static readonly Stopwatch _stopwatch = new();
    private static readonly ProgressBar _progressBar = new();
    public static int CF = 0; //this variable keeps track of how mnay fishes were caught

    /*Static Constructor:
       static Fishing(): This is a static constructor.
       It runs automatically before any static members of the class are accessed.
       In this constructor, fish objects are created and added to
       the Fishes list in the sea instance of the Sea class.
     */
    static Fishing() 
    {
        _sea.Fishes.Add(new Fish("Salmon", "", 5, 5, 5, true));
        _sea.Fishes.Add(new Fish("Cod", "", 1, 1, 2, true));
        _sea.Fishes.Add(new Fish("Swordfish", "", 8, 7, 8, true));
        _sea.Fishes.Add(new Fish("Shark", "", 9, 9, 10, true));
        _sea.Fishes.Add(new Fish("Tuna", "", 7, 4, 8, true));
        _sea.Fishes.Add(new Fish("Anchovy", "", 1, 1, 1, true));
        _sea.Fishes.Add(new Fish("Clown Fish", "", 1, 10, 9, false));
        _sea.Fishes.Add(new Fish("Blobfish", "", 3, 9, 8, false));
    }

    /*public static void ClearBuffer()
    {
        while (Console.KeyAvailable) Console.ReadKey(true);
    }*/
    
    private static int RandomFish()
    {
        var index = _random.Next(_sea.Fishes.Count);
        Debug.WriteLine($"RandomFish executed correctly, index: {index}");
        return index;
        //could be done in one single line
    }

    private static void FishingWait()
    {   
        Console.Clear();
        Console.WriteLine("Press any key to throw your rod 🎣: ");
        Console.ReadKey(); 
        Console.Clear();
        var randomDuration = _random.Next(6, 19); //random number between 6 and 19
        _stopwatch.Start(); // starts stopwatch

        while (_stopwatch.Elapsed.TotalSeconds < randomDuration) //while time passed is less than...
        {
            CBuffer.ClearBuffer();
            BubblesAnimation.DrawBubbles();
            Thread.Sleep(1000);
        }

        _stopwatch.Stop(); //stops it
        _stopwatch.Reset(); //resets it
        CBuffer.ClearBuffer();
    }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private static async Task FishingCatch()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
        Console.Clear();
        var token = new CancellationTokenSource();
        var ct = token.Token;

        var randomDuration = _random.Next(1, 3);
        _stopwatch.Start();
        var progressTask = Task.Run(() => _progressBar.Progress(randomDuration, ct));

        while (_stopwatch.Elapsed.TotalSeconds < randomDuration)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                if (_stopwatch.Elapsed.TotalSeconds >= randomDuration)
                {
                    Console.WriteLine("You were too slow, try again");
                    Console.WriteLine("\npress an key to continue \n");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    token.Cancel();
                    Console.Clear();
                    Console.WriteLine("🐟🐠");
                    Console.WriteLine($"You caught a {_sea.Fishes[RandomFish()].Name}");
                    CF++;
                    Console.WriteLine("\npress an key to continue \n");
                    Console.ReadKey();
                    break;
                }
            }
        } 
        _stopwatch.Stop();
        _stopwatch.Reset();
    }

    public static async void FishingGame()
    {
        FishingDialog.InitialDialog();
        Console.WriteLine("Fishing game started");
        while(CF < 5)
        {
            FishingWait();
            await FishingCatch();
        }
        Console.ReadKey(false);
    }
}

public class FishingDialog
{
    public static void InitialDialog()
    {
        Console.WriteLine("Sustainable fishing is about catching fish in a way that keeps our oceans healthy and ensures there are enough fish for the future.");
        Console.WriteLine("It means using methods that don't harm the environment, like setting limits on how many fish can be caught,");
        Console.WriteLine("making sure fish are big enough to reproduce before being caught, and protecting important areas in the ocean.");
        Console.WriteLine("By using smart fishing techniques and taking care of the ocean, we can enjoy seafood without harming the balance of marine life");
        Console.WriteLine("or hurting the livelihoods of people who depend on fishing.");
        Console.WriteLine("\npress an key to continue \n");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Fishing with a rod is sustainable because it's a selective and controlled method.");
        Console.WriteLine("Anglers target specific fish species, releasing non-target or undersized fish back into the water.");
        Console.WriteLine("This practice helps maintain balanced fish populations and allows young fish to grow, ensuring future generations.");
        Console.WriteLine("Additionally, catch limits and regulations are often in place, preventing overfishing.");
        Console.WriteLine("Compared to more industrial methods, rod fishing has a lower environmental impact and promotes a connection between people and the environment.");
        Console.WriteLine("Fostering a sense of responsibility toward sustainable practices.");
        Console.WriteLine("\npress an key to continue \n");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Welcome to the Fishing Game!");
        Console.WriteLine("Press any key to throw your fishing rod into the virtual Sea.");
        Console.WriteLine("Wait patiently as bubbles appear, indicating fish activity.");
        Console.WriteLine("After a while, a shrinking bar will appear on the screen.");
        Console.WriteLine("Press the spacebar when the shrinking bar aligns appears to catch the fish.");
        Console.WriteLine("Successfully catch 5 fishes to win the game!");
        Console.WriteLine("Remember, timing is crucial to reel in your catch.");
        Console.WriteLine("Good luck, angler! Press any key to start the game.");
        Console.ReadKey();
        Console.Clear();
    }
}

public class BubblesAnimation
{  
    private const string filePath = "assets/ascii-art.txt";
    private static string[] art = File.ReadAllLines(filePath);
    private static int _windowWidth = Console.WindowWidth; 
    private static int _windowHeight = Console.WindowHeight;
    private static readonly Random _random = new(Guid.NewGuid().GetHashCode());
    public static void DrawBubbles()
    {
        int X = _random.Next(16, _windowWidth - 16);
        int Y = _random.Next(11, _windowHeight - 11);
        
        
        int count = 0;
        foreach (var line in art)
        {
            CBuffer.ClearBuffer();
            Console.CursorVisible = false; 
            Console.SetCursorPosition(X, Y + count);
            Console.WriteLine(line);
            count++;
        }
    }
}

public class ProgressBar
{
    private const int TotalChars = 50;
    
    private static int X = Console.WindowWidth / 2;
    private static int Y = Console.WindowHeight / 2;
    
    public void Progress(int totalSeconds, CancellationToken ct)
    {
        for (var i = 0; i <= 100; i++)
        {
            if (ct.IsCancellationRequested)
            {
                ct.ThrowIfCancellationRequested();
                return;
            }
            DrawBar(i);
            Thread.Sleep(totalSeconds * 10);
        }
    }

    private static void DrawBar(int progress) 
    {
        Console.CursorVisible = false;
        var currentChars = (int)(progress / 100.0 * TotalChars);
        
        Console.SetCursorPosition(X, Y);
        Console.Write("\r");
        Console.Write(new string(' ', currentChars));
        Console.Write(new string('\u2588', TotalChars - currentChars));
        Console.Write(new string('\u2588', TotalChars - currentChars));
        Console.Write(new string(' ', TotalChars));
    }
}
}
