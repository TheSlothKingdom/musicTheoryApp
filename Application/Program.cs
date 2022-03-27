using System;
using System.Collections.Generic;

namespace musicTheoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Questions> questionsList = Questions.Initialize();

            int correctAnswers = 0;
            int totalQuestions = 0;

            bool runLoop = true;
            while(runLoop)
            {
                Console.Clear();
                Console.WriteLine("choose an option");
                Console.WriteLine("\n1 scales\n2 quiz\n3 quiz results\n4 convert temperature");
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
                        while (i < questionsList.Count)
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
                        totalQuestions += 5;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("quiz results");
                        Console.WriteLine(correctAnswers + " out of " + totalQuestions);
                        double displayPercentage = Questions.CalculatePercentageCorrect(correctAnswers, totalQuestions);
                        Console.WriteLine((displayPercentage * 100).ToString("##.##") + "%");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("convert temperature\n");
                        Console.WriteLine("press 1 for Fahrenheit to Celsius");
                        Console.WriteLine("press 2 for Celsius to Fahrenheit");
                        string temperatureTypeConvertString = Console.ReadLine();
                        int temperatureTypeConvert = int.Parse(temperatureTypeConvertString);

                        switch (temperatureTypeConvert)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the temperature in Fahrenheit\n");
                                string temperatureFahrenheitString = Console.ReadLine();
                                int temperatureFahreheit = int.Parse(temperatureFahrenheitString);
                                double convertedTemperatureCelsius = TemperatureConversion.ConvertFToC(Convert.ToDouble(temperatureFahreheit));
                                if (convertedTemperatureCelsius == 0)
                                {
                                    Console.WriteLine("0C");
                                }
                                Console.WriteLine(convertedTemperatureCelsius.ToString("##.##") + "C");
                                break;

                            case 2:
                                Console.WriteLine("\nEnter the temperature in Celsius");
                                string temperatureCelsiusString = Console.ReadLine();
                                int temperatureCelsius = int.Parse(temperatureCelsiusString);
                                double convertedTemperatureFahrenheit = TemperatureConversion.ConvertCToF(Convert.ToDouble(temperatureCelsius));
                                if (convertedTemperatureFahrenheit == 0)
                                {
                                    Console.WriteLine("0F");
                                }
                                Console.WriteLine(convertedTemperatureFahrenheit.ToString("##.##") + "F");
                                break;
                        }
                        break;
                }

                Console.WriteLine("\nback to menu? yes or no");
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

            public static double CalculatePercentageCorrect(int correctAnswers, int totalQuestions)
            {
                if (totalQuestions != 0)
                {
                    double percentageCorrect = Convert.ToDouble(correctAnswers) / Convert.ToDouble(totalQuestions);
                    return percentageCorrect;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class TemperatureConversion
        {
            public static double ConvertFToC(double temperatureFahrenheit)
            {
                double temperatureCelsius = (temperatureFahrenheit - 32) * .5556;
                return temperatureCelsius;
            }
            public static double ConvertCToF(double temperatureCelsius)
            {
                double temperatureFahrenheit = (temperatureCelsius * 1.8) + 32;
                return temperatureFahrenheit;
            }
        }
    }
}
