using System;
using System.Collections.Generic;

namespace musicTheoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Questions> questionsList = Questions.Initialize();

            Console.WriteLine(questionsList);

            /*Questions question1 = new Questions
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

            questionsList.Add(Questions.Initialize();
            questionsList.Add(question2);
            questionsList.Add(question3);
            questionsList.Add(question4);
            questionsList.Add(question5);*/

            int correctAnswers = 0;

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
                        Console.Clear();
                        Console.WriteLine("QUIZ");

                        int i = 0;
                        while ( i<questionsList.Count)
                        {
                            Console.WriteLine("Question " + questionsList[i].QuestionNumber);
                            Console.WriteLine(questionsList[i].Question);
                            if (questionsList[i].Answer.ToLower() != Console.ReadLine())
                            {
                                Console.WriteLine("Incorrect");
                                Console.WriteLine();
                            }
                            else
                            {
                                correctAnswers++;
                                Console.WriteLine("Correct!");
                                Console.WriteLine();
                            }

                            i++;
                        }

                        /*Console.WriteLine("Question: " + questionsList[0].QuestionNumber);
                        Console.WriteLine(question1.Question);
                        string answerOne = Console.ReadLine();
                        if(question1.Answer.ToLower() != answerOne.ToLower())
                        {
                            Console.WriteLine("Incorrect");
                            Console.WriteLine();
                        }
                        else
                        {
                            correctAnswers++; 
                            Console.WriteLine("Correct!");
                            Console.WriteLine();
                        }

                        Console.WriteLine("Question: " + question2.QuestionNumber);
                        Console.WriteLine(question2.Question);
                        string answerTwo = Console.ReadLine();
                        if (question2.Answer.ToLower() != answerTwo.ToLower())
                        {
                            Console.WriteLine("Incorrect");
                            Console.WriteLine();
                        }
                        else
                        {
                            correctAnswers++;
                            Console.WriteLine("Correct!");
                            Console.WriteLine();
                        }

                        Console.WriteLine("Question: " + question3.QuestionNumber);
                        Console.WriteLine(question3.Question);
                        string answerThree = Console.ReadLine();
                        if (question3.Answer.ToLower() != answerThree.ToLower())
                        {
                            Console.WriteLine("Incorrect");
                            Console.WriteLine();
                        }
                        else
                        {
                            correctAnswers++;
                            Console.WriteLine("Correct!");
                            Console.WriteLine();
                        }

                        Console.WriteLine("Question: " + question4.QuestionNumber);
                        Console.WriteLine(question4.Question);
                        string answerFour = Console.ReadLine();
                        if (question4.Answer.ToLower() != answerFour.ToLower())
                        {
                            Console.WriteLine("Incorrect");
                            Console.WriteLine();
                        }
                        else
                        {
                            correctAnswers++;
                            Console.WriteLine("Correct!");
                            Console.WriteLine();
                        }

                        Console.WriteLine("Question: " + question5.QuestionNumber);
                        Console.WriteLine(question5.Question);
                        string answerFive = Console.ReadLine();
                        if (question5.Answer.ToLower() != answerFive.ToLower())
                        {
                            Console.WriteLine("Incorrect");
                            Console.WriteLine();
                        }
                        else
                        {
                            correctAnswers++;
                            Console.WriteLine("Correct!");
                            Console.WriteLine();
                        }*/

                        break;

                    case 3:
                        Console.WriteLine("quiz results");
                        Console.WriteLine(correctAnswers + " out of 5");
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

            public static List<Questions> Initialize()
            {
                List<Questions> questionsList = new List<Questions>();

                Questions question1 = new Questions
                {
                    QuestionNumber = 1,
                    Question = "Is this major or minor??\nC D E F G A B C",
                    Answer = "Major"
                };
                questionsList.Add(question1);

                Questions question2 = new Questions
                {
                    QuestionNumber = 2,
                    Question = "Is this major or minor??\nA B C D E F G A",
                    Answer = "Minor"
                };
                questionsList.Add(question2);

                Questions question3 = new Questions
                {
                    QuestionNumber = 3,
                    Question = "Is this major or minor??\nEb F G Ab Bb C D Eb",
                    Answer = "Major"
                };
                questionsList.Add(question3);

                Questions question4 = new Questions
                {
                    QuestionNumber = 4,
                    Question = "Is this major or minor??\nC D Eb F G Ab Bb C",
                    Answer = "Minor"
                };
                questionsList.Add(question4);

                Questions question5 = new Questions
                {
                    QuestionNumber = 5,
                    Question = "Bonus Question! Is this major or minor??\nF G A Bb C D E F",
                    Answer = "Major"
                };
                questionsList.Add(question5);

                return questionsList;
            }
        }
    }
}
