using System.Timers;
using Viktoras;

namespace Viktoras
{
    public class Countdown
    {
        public static System.Timers.Timer? timer;
        public static int timeLeft = 180;
        public static void StartCountDown()// method for starting a timer
        {
            timer = new System.Timers.Timer(1000);
#pragma warning disable CS8622 
            timer.Elapsed += TimerSeconds;
#pragma warning restore CS8622 
            timer.Start();
        }

        public static void TimerSeconds(object sender, ElapsedEventArgs e)//printing time to console
        {
            Console.SetCursorPosition(40, 0);
            Console.ForegroundColor = ConsoleColor.Gray;
            if (timeLeft >= 100)
            {
                Console.WriteLine($"Time: {timeLeft} seconds");
            }
            else if (timeLeft >= 10)
            {
                Console.WriteLine($"Time:  {timeLeft} seconds");
            }
            else if (timeLeft < 10)
            {
                Console.WriteLine($"Time:   {timeLeft} seconds");
            }
            timeLeft--;
            if (timeLeft < 0) // ckecking if the time ended
            {
#pragma warning disable CS8602
                timer.Stop();
#pragma warning restore CS8602 
                PopUpTexts.TimeEnds();
                Console.ReadKey();
            }
        }

    }
}


