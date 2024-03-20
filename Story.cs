namespace GameTexts
{
    public class Story
    {
        public static void StartEurope()
        {
            Console.Clear();
            Console.WriteLine(@"You arrive at a power station, and it looks bad, some cables are destroyed, and the workers seem to be very busy and overwhelmed with the amount of work. 
You ask around about what happened and how you can help, and after a few attempts, one of them answers your questions. 
He explains that they aren’t fully sure themselves about what happened but if you are willing to help then he can give you a task.  
He then explains that it would help them out a lot if you could connect a cable, that he points to, to the somewhat nearby power source. 
Although to get there you will have to get through a maze that is in the way. 
After having explained the instructions to you he quickly goes back to work, and then you pick up the cable and approach the maze.

Press Enter to start the game");
            ContinueText();
            Console.Clear();

        }
        public static void StartAsia()
        {
            Console.Clear();
            Console.WriteLine(@"You have arrived in Asia and immediately notice the high amount of waste, and it is clear that people are struggling
to do anything about it. You remember that in the news it was mentioned that in Asia they were struggling with a high amount of waste, 
so you decided that it is what you must help them with.  
You start to gather a lot of trash, and once you are happy with how much you have gathered, 
it becomes time for you to sort the trash so it can be recycled and/or taken care of correctly. 
So, you bring all the trash to a facility that will make it easier for you to sort it all.

Press Enter to start the game");
            ContinueText();
            Console.Clear();

        }
        public static void StartOceania()
        {
            Console.Clear();
            Console.WriteLine(@"You have arrived in Oceania. Here you will need to encourage the correct way of fishing by showing people
how to catch fishes correctly. The people start gathering around you when you take your fishing rod and now it is your
time to shine and make an impact.

Press Enter to start the game");
            ContinueText();
            Console.Clear();
        }
        public static void StartAfrica()
        {
            Console.Clear();
            Console.WriteLine(@"You have arrived in Africa. You remember the news having mentioned there here the problem is that the people are starving.
So, you get the idea that to help them, you could help with the food supply problems. You have to teach the people about food intake.

Press Enter to start the game ");
            ContinueText();
            Console.Clear();

        }
        public static void StartAmerica()
        {
            Console.Clear();
            Console.WriteLine(@"You arrive in America, and you notice that the people around here seem not to be doing so well.
Some people are coughing, some are sneezing, some seem very fatigued, and some people have other symptoms. 
You remember that the news talked about diseases causing issues in America, and although you might not be a professional in helping
people with diseases, you decide to do your best to help them anyway.  
After walking around for a bit, you end up near this building where some human wellness professionals are seen busy at work
trying to help people with many different symptoms.  
You ask if there is any way you could help them, and although hesitant at first, 
they decide to give the center into your hands and the future of the patients is in your hands! 

Press Enter to start the game ");
            ContinueText();
            Console.Clear();
        }
        public static void EndEurope()
        {
            Console.Clear();
            Console.WriteLine(@"After having successfully connected a lot of cables, the man from earlier once again starts talking to you, 
and he thanks you for the help and says that they should have the rest covered from here, so you are free to go. 
As you are about to leave you notice something glowing close to the last cable you connected. You walk up to the glowing object 
and it looks like some weird part of a device that for some reason has this blue glow to it, which you assume must be from the materials
it is made of, but the glow seems almost unnatural.  
You decide to keep the part and take it with you as you continue to the next continent.

Press Enter to continue your journey");
            ContinueText();
            Console.Clear();
        }
        public static void EndAsia()
        {
            Console.Clear();
            Console.WriteLine(@"After having gone through the piles of trash that you collected, you are ready to continue to the next place,
but before you get the chance to leave you notice something glowing in one of the bags that you had used to collect the trash. 
It is supposed to be empty since you sorted it all, so you go to check out what this glowing thing could be.  
When you get a closer look, you realize it looks like a part of a strange device,
you conclude that it will probably be useful and bring it along with you as you leave.

Press Enter to continue your journey");
            ContinueText();
            Console.Clear();
        }
        public static void EndAmerica()
        {
            Console.Clear();
            Console.WriteLine(@"After having helped to run a wellness center, you are told that you have helped enough and are free to leave. 
While you are leaving, one of the patients stops you.  
The patient explains that they had found this strange thing with a blue glow. Since he has no use for it, they want to give it to you as a thank you for helping 
them with their disease.  
The patient then gives you a part of the device, you thank him as you leave the building.  

Press Enter to continue your journey");
            ContinueText();
            Console.Clear();
        }
        public static void EndOceania()
        {
            Console.Clear();
            Console.WriteLine(@"As you decide that you are done fishing, you start to pack your things with the intent to leave. 
But as you pack your things it seems that your fishing rod has caught something.  
You quickly grab your fishing rod to try to fish up whatever it might have caught. 
It takes a little bit, and you finally can slightly see what it is, and you notice this blue glow.  
As the object reaches the surface it becomes clear that it is a part of the device. 
You take it off the hook and take it with you as you pack the last things and leave for the next location.

Press Enter to continue your journey");
            ContinueText();
            Console.Clear();
        }
        public static void EndAfrica()
        {
            Console.Clear();
            Console.WriteLine(@"Everyone seems to be doing better, and it is time to continue to the next location.  
But before you leave you notice a strange blue glow from one of the crops in a nearby field.  
You go to investigate what it is, and you notice that it seems to potentially be a part of the device, 
so you pick it up and take it with you as you leave the continent.  

Press Enter to continue your journey");
            ContinueText();
            Console.Clear();
        }
        static void ContinueText()
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
            }
        }

        public static void StartFinalBoss() {
            Console.Clear();
            Console.WriteLine(@"You gaze upon your assembled device, realizing that all the collected 
artifacts have merged into a singular, ominous creation. As you activate it, the device vibrates and hums,
unveiling an otherworldly interface that connects you directly to the malevolent
entity encountered at the journey's outset. Sinister symbols and pulsating energy manifest on the 
interface, visually symbolizing the connection. A dark and ancient voice emanates, posing challenging 
questions that you must answer to defeat the evil force. With each correct response, the malevolence weakens, 
and the device becomes a formidable tool not only for communication but also for overcoming the entity's dark influence");
            ContinueText();
            Console.Clear();
        }

        public static void EndFinalBoss(){
            Console.Clear();
            Console.WriteLine(@"With the combined device, you faced the evil entity, answering its questions. 
Your newfound knowledge weakened its grip, and as the entity vanished, humanity was saved. 
The device, once a conduit for evil, now stands as a powerful tool, reshaping your extraordinary journey for the better."); 
            ContinueText();
            Console.Clear();
        }


    }

}
