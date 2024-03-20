
class BossFight
{
    private static bool playQuiz = true;
    private static int questionLoop = 0;
    private static int quizScore = 0;
    public static void RunBattle()
    {
        Console.WriteLine("Boss battle");
        Questions.QuestionBase currentQuestion = Questions.QuizQuestions[0];
        while(playQuiz)
        {
            Console.WriteLine($"{Questions.QuizQuestions[questionLoop].questionText}");
            int possibleAnswers = 3;
            int answerLoop = 1;
            while(answerLoop<=possibleAnswers)
            {
                Console.WriteLine($"{answerLoop}) {Questions.QuizQuestions[questionLoop].QuizAnswers[answerLoop]}");
                answerLoop++;
            }
            string? userChoice = Console.ReadLine();
            int rightChoice;
            bool inputCorrect = int.TryParse(userChoice, out int correctChoice);
            if(inputCorrect)
            {
                rightChoice = correctChoice;
                if (rightChoice == Questions.QuizQuestions[questionLoop].rightAnswer)
                {
                    Console.WriteLine("Correct!");
                    quizScore++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
            else
            {
                Console.WriteLine("Input is not integer");
            } 
            Console.WriteLine("Press any key to continue");
            Console.ReadLine(); 
            questionLoop++;
            if(questionLoop >= Questions.QuizQuestions.Count)
            {
                Console.Clear();
                Console.WriteLine($"Out of all questions you correctly answered {quizScore}!");
                Console.WriteLine(Questions.QuizQuestions.Count);
                if (quizScore>=Questions.QuizQuestions.Count-3)
                {
                    Console.WriteLine("You are a true hero!");
                    Console.WriteLine(@"You managed not only to save the world, but also to learn a lot about
sustainability. Now you can move on and make a difference in the real world! See you!");
                    Environment.Exit(0);
                }
                if (quizScore<Questions.QuizQuestions.Count-3)
                {
                    Console.WriteLine(@"You did not perform really well in the battle.
The future of our planet is in your hands. Try again and now try to beat the enemy!
Press any key to play again");
                    Console.ReadKey();
                    playQuiz = true;
                    quizScore = 0;
                    questionLoop = 0;
                    Console.Clear();
                    RunBattle();
                }
            }
        }
    }
}
