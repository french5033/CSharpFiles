using System;

//namespace
namespace NumberGuesser {

    //main class
    class Program {
        //entry method
        static void Main(string[] args) {

            GetAppInfo();

            GetGreeting();

            while (true) {
                // Set correct number
                Random random = new Random();
                int number = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != number) {
                    string inputNumber = Console.ReadLine();
                    if (!int.TryParse(inputNumber, out guess)) { ///Check input
                        PrintWithColor(ConsoleColor.Red, "Not a number");
                        continue;
                    }

                    guess = Int32.Parse(inputNumber); //Cast to int, put into guess var

                    if (guess != number) {
                        PrintWithColor(ConsoleColor.Red, "Wrong number");
                    } else if (guess == number){
                        PrintWithColor(ConsoleColor.Green, "Correct");
                        Console.WriteLine("Play Again? [Y or N]");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y") {
                            continue;
                        } else if (answer == "N") {
                            return;
                        } else {
                            return;
                        }
                    } else {
                        Console.WriteLine("Error");
                    }
                }
            }
        }

        static void GetAppInfo(){
            string appName = "Number Guess";
            string appVersion = "1.0.0";
            string appAuthor = "Stephanie";

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GetGreeting(){
            // Ask for input
            Console.WriteLine("What is your name?");
            // Get input
            string inputName = Console.ReadLine();
            // output
            Console.WriteLine("Hello {0}, let's game", inputName);
        }

        static void PrintWithColor(ConsoleColor color, string message){
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
