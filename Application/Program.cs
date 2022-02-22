using System;

namespace musicTheoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runLoop = true;
            while(runLoop)
            {
                Console.WriteLine("choose an option");
                Console.WriteLine("1 - scales 2 - quiz - 3 quiz results 4 - print results");
                string navigateString = Console.ReadLine();
                int navigate = int.Parse(navigateString);

                switch (navigate)
                {
                    case 1:
                        Console.WriteLine("scales");
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
