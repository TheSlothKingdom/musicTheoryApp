using System;
using System.Collections.Generic;

namespace musicTheoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Questions> questionsList = new List<Questions>();

            Questions.Initialize(); 


            Questions question1 = new Questions
            {
                QuestionNumber = 1,
                Question = "Is this major or minor??\nC D E F G A B C",
                Answer = "Major"
            };

            Questions question2 = new Questions
            {
                QuestionNumber = 2,
                Question = "Is this major or minor??\nA B C D E F G A",
                Answer = "Minor"
            };

            Questions question3 = new Questions
            {
                QuestionNumber = 3,
                Question = "Is this major or minor??\nEb F G Ab Bb C D Eb",
                Answer = "Major"
            };

            Questions question4 = new Questions
            {
                QuestionNumber = 4,
                Question = "Is this major or minor??\nC D Eb F G Ab Bb C",
                Answer = "Minor"
            };

            Questions question5 = new Questions
            {
                QuestionNumber = 5,
                Question = "Bonus Question! Is this major or minor??\nF G A Bb C D E F",
                Answer = "Major"
            };

            questionsList.Add(question1);
            questionsList.Add(question2);
            questionsList.Add(question3);
            questionsList.Add(question4);
            questionsList.Add(question5);

            bool runLoop = true;
            while(runLoop)
            {
                Console.Clear();
                Console.WriteLine("choose an option");
                Console.WriteLine("\n1 scales\n2 quiz\n3 quiz results\n4 print results");
                Console.WriteLine("\nType the corresponding number and press ENTER\n");

                string navigateString = Console.ReadLine();
                int navigate = int.Parse(navigateString);

                switch (navigate)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Major Scale\nHas a bright sound and a major third\n\nExamples\nC Major: C D E F G A B C\nEb Major: Eb F G Ab Bb C D Eb\n");
                        Console.WriteLine("Minor Scale\nHas a dark sound and a minor third\n\nExamples\nA Minor: A B C D E F G A\nC Minor: C D Eb F G Ab Bb C\n");
                        break;

                    case 2:
                        Console.WriteLine("quiz");
                        break;

                    case 3:
                        Console.WriteLine("quiz results");
                        break;

                    case 4:
                        Console.WriteLine("print");
                        break;
                }

                Console.WriteLine("back to menu? yes or no");
                string loopOrExit = Console.ReadLine();

                if (loopOrExit == "no")
                {
                    runLoop = false;
                }

            }
        }

        public class Questions
        {
            public int QuestionNumber { get; set; }
            public string Question { get; set; }
            public string Answer { get; set; }

            public static void Initialize()
            {
                Questions question1 = new Questions
                {
                    QuestionNumber = 1,
                    Question = "Is this major or minor??\nC D E F G A B C",
                    Answer = "Major"
                };
            }
        }
    }
}
