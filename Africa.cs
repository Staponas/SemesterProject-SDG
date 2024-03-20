namespace SemesterProjectAfrica
{
    class Africa
    {

       //Simple math based mini-game

       public static void RunAfrica()
       {

        //Introduction to the game

        Console.WriteLine("");
        Console.Write("On average someone assigned female at birth are recommended to have an intake of around 2,000 calories a day, "); 
        Console.Write("and someone assigned male at birth are recommended to have an intake of around 2,500 calories a day. So, for "); 
        Console.WriteLine("this minigame we are just gonna say that a person requires 2,300 calories");
        Console.WriteLine("");
        Console.Write("To complete this mini-game you need to answer eight questions.");
        Console.WriteLine(" The questions will be mathematical, and you will have to keep answering until you get the correct answer.");
        Console.WriteLine("");

        //The questions

        Question1();

        Question2();
        
        Question3();

        Question4();

        Question5();

        Question6();

        Question7();

        Question8();


        //A potential ending to the mini-game

        Console.WriteLine("");
        Console.WriteLine("You did it, you answered all the questions and can now continue your journey.");
        Console.WriteLine("");
        Console.Write("In 2021 around 768 million people were experiencing hunger. And in 2022 around 45 million children under ");
        Console.Write("age 5 were affected by wasting, which is when a child's weight for height is below a certain amount. ");
        Console.Write("Wasting is a form of malnutrition and it is also life-threatening. ");
        Console.WriteLine("Which is one of the reasons why it is important to do something to end hunger.");
        Console.WriteLine("");

       }

        //The code for the questions, which is close to just being the same code repeated with some changes made
        //in the text and answer parts.
        public static void Question1()
        {
            Console.WriteLine("");
            Console.WriteLine("Question 1:");
            Console.Write("There is four people asking for food. How many calories worth of food would you need to be able feed these ");
            Console.Write("four people? (based on the amount ");
            Console.WriteLine("required per person that was explained earlier)");
            Console.WriteLine("(Also do not put ',' or '.' between the numbers when you answer the questions, since it will be seen as incorrect.)");
            Console.WriteLine("");
            
            while(true)
            {
                bool question1Answer = false;
                int answer1 = 0;
                question1Answer = int.TryParse(Console.ReadLine(), out answer1);
                if(!question1Answer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
                else
                {

                    if(answer1 == 9200)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is incorrect, try again.");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }
        }

        public static void Question2()
        {
            Console.WriteLine("");
            Console.WriteLine("Question 2:");
            Console.WriteLine("There is a container with 11,500 calories worth of food. How many people can you feed?");
            Console.WriteLine("");


            while(true)
            {
                bool question2Answer = false;
                int answer2 = 0;
                question2Answer = int.TryParse(Console.ReadLine(), out answer2);
                if(!question2Answer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
                else
                {

                    if(answer2 == 5)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is incorrect, try again.");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }
        }

        public static void Question3()
        {
            Console.WriteLine("");
            Console.WriteLine("Question 3:");
            Console.Write("You need to get enough food to feed 32 people. ");
            Console.WriteLine("How many calories worth of food do you need to be able to feed the 32 people?");
            Console.WriteLine("");

            while(true)
            {
                bool question3Answer = false;
                int answer3 = 0;
                question3Answer = int.TryParse(Console.ReadLine(), out answer3);
                if(!question3Answer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
                else
                {

                    if(answer3 == 73600)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is incorrect, try again.");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }

        }

        public static void Question4()
        {

            Console.WriteLine("");
            Console.WriteLine("Question 4:");
            Console.WriteLine("You have 115,000 calories worth of food. How many people are you able feed with that amount?");
            Console.WriteLine("");
            
            while(true)
            {
                bool question4Answer = false;
                int answer4 = 0;
                question4Answer = int.TryParse(Console.ReadLine(), out answer4);
                if(!question4Answer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
                else
                {

                    if(answer4 == 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is incorrect, try again.");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }

        }        
        
        public static void Question5()
        {
            Console.WriteLine("");
            Console.WriteLine("Question 5:");
            Console.Write("You have 36,000 calories worth of food and there is 20 people asking for food. ");
            Console.WriteLine("How many calories worth of food can you give each person if you split it evenly among them?");
            Console.WriteLine("");

            while(true)
            {
                bool question5Answer = false;
                int answer5 = 0;
                question5Answer = int.TryParse(Console.ReadLine(), out answer5);
                if(!question5Answer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
                else
                {

                    if(answer5 == 1800)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is incorrect, try again.");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }
        }

        public static void Question6()
        {
            Console.WriteLine("");
            Console.WriteLine("Question 6:");
            Console.Write("You have two containers of food, one has 73,600 calories worth of food, the other has 115,000 calories ");
            Console.WriteLine("worth of food. How many people can you feed with the food in those two containers?");
            Console.WriteLine("");

            while(true)
            {
                bool question6Answer = false;
                int answer6 = 0;
                question6Answer = int.TryParse(Console.ReadLine(), out answer6);
                if(!question6Answer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
                else
                {

                    if(answer6 == 82)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is incorrect, try again.");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }
        }

        public static void Question7()
        {
            Console.WriteLine("");
            Console.WriteLine("Question 7:");
            Console.Write("In one town there is 23 people and in another town nearby there is 16 people. ");
            Console.WriteLine("How many calories worth of food is required to feed the people in both the towns?");
            Console.WriteLine("");

            while(true)
            {
                bool question7Answer = false;
                int answer7 = 0;
                question7Answer = int.TryParse(Console.ReadLine(), out answer7);
                if(!question7Answer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
                else
                {

                    if(answer7 == 89700)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is incorrect, try again.");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }
        }

        public static void Question8()
        {
            Console.WriteLine("");
            Console.WriteLine("Question 8:");
            Console.Write("You have three containers. One has 9,200 calories worth of food, another has 20,700 calories and the ");
            Console.Write("last one has 29,900 calories. There is a group with 12 people, one with 5 people and one with 6 people. ");
            Console.WriteLine("If you were to split the food evenly among the people how many calories worth of food would a person be able to get?");
            Console.WriteLine("");

            while(true)
            {
                bool question8Answer = false;
                int answer8 = 0;
                question8Answer = int.TryParse(Console.ReadLine(), out answer8);
                if(!question8Answer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
                else
                {

                    if(answer8 == 2600)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is incorrect, try again.");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }

        }

    }
}
