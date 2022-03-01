using System;
using System.Collections.Generic;

namespace musicTheoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                    case 5:
                        Console.WriteLine("quiz");
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
    }
}
