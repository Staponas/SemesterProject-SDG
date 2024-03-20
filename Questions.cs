public class Questions
{
    public class QuestionBase
    {
        public string questionText;
        public Dictionary<int, string> QuizAnswers;
        public int rightAnswer;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public QuestionBase()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            QuizAnswers = new Dictionary<int, string>();
        }
    }

    public static List<QuestionBase> QuizQuestions = new List<QuestionBase>
    {
        new QuestionBase
        {
            questionText = "Since 1990 global emissions of CO2:",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Increased"},
                {2, "Decreased"},
                {3, "Remained the same"}
            },
            rightAnswer = 1
        },
        new QuestionBase
        {
            questionText = "What SDG 7 is about?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Zero hunger"},
                {2, "Life below water"},
                {3, "Affordable and clean energy"}
            },
            rightAnswer = 3
        },
        new QuestionBase
        {
            questionText = @"What is the single largest renewable energy source today that provides 10% of world primary energy supply?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Wind power"},
                {2, "Bioenergy"},
                {3, "Solar power"}
            },
            rightAnswer = 2
        },
        new QuestionBase
        {
            questionText = "How clean do items need to be before going in the recycling bin? ",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Dirty is fine"},
                {2, "Pretty clean with most food or liquid washed out "},
                {3, "Spotless"}
            },
            rightAnswer = 2
        },
        new QuestionBase
        {
            questionText = "Can a battery be recycled? ",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Yes"},
                {2, "No"},
                {3, "I need more information"}
            },
            rightAnswer = 1
        },
        new QuestionBase
        {
            questionText = "What are three common items you can easily recycle at home, and how do you ensure they are properly disposed of?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Plastic bottles, paper products, aluminium cans"},
                {2, "Nothing"},
                {3, "Tyres, engines"}
            },
            rightAnswer = 1
        },
        new QuestionBase
        {
            questionText = "What is a key determinant of achieving good health and well-being in communities?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Sustainable consumption and production practices"},
                {2, "Availability of clean and safe drinking water"},
                {3, "Access to quality education"}
            },
            rightAnswer = 1
        },
        new QuestionBase
        {
            questionText = "In the context of promoting well-being, what factor is crucial for building resilient healthcare systems?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Strengthening economic partnerships"},
                {2, "Expanding urban infrastructure"},
                {3, "Developing robust healthcare infrastructure"},
            },
            rightAnswer = 3
        },
        new QuestionBase
        {
            questionText = "How can communities contribute to the realization of good health and well-being?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "Prioritizing preventive healthcare measures"},
                {2, "Engaging in sustainable agriculture practices"},
                {3, "Fostering cultural diversity"}
            },
            rightAnswer = 1
        },
        new QuestionBase
        {
            questionText = "How many calories of food a day is recommended for someone assigned male at birth?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "2000 calories"},
                {2, "2300 calories"},
                {3, "2500 calories"}
            },
            rightAnswer = 3
        },
        new QuestionBase
        {
            questionText = "Around how many people were experiencing hunger in 2021?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "687 million"},
                {2, "768 million"},
                {3, "936 million"}
            },
            rightAnswer = 2
        },
        new QuestionBase
        {
            questionText = "In 2022 around how many children under the age of 5 were affected by wasting?",
            QuizAnswers = new Dictionary<int, string>
            {
                {1, "36 million"},
                {2, "45 million"},
                {3, "57 million"}
            },
            rightAnswer = 2
        },
            //oceania questions
            new QuestionBase
            {
                questionText = "What is the primary goal of sustainable fishing?",
                QuizAnswers = new Dictionary<int, string>
                {
                    {1, "Maximizing fish catch"},
                    {2, "Minimizing harm to the environment"},
                    {3, "Increasing industrial fishing methods"}
                },
                rightAnswer = 2
            },
            new QuestionBase
            {
                questionText = "How does fishing with a rod contribute to sustainability?",
                QuizAnswers = new Dictionary<int, string>
                {
                    {1, "By catching as many fish as possible"},
                    {2, "Releasing non-target or undersized fish"},
                    {3, "Ignoring catch limits and regulations"}
                },
                rightAnswer = 2
            },
            new QuestionBase
            {
                questionText = "How does sustainable fishing contribute to the well-being of marine life and fishing communities, as mentioned in the provided information?",
                QuizAnswers = new Dictionary<int, string> 
                {
                    {1, "By maximizing fish catch"},
                    {2, "By ensuring the balance of marine life and supporting fishing communities"},
                    {3, "By making fishing more accessible to communties"}
                }, 
                rightAnswer = 2
            }
    };

}
