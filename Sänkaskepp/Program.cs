using System;

namespace Sänkaskepp
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            bool exit = false;
            while (true)
            {

                while (true)
                {
                    Console.WriteLine("Choose the correct answer. The correct answer must be between 1-10");
                    answer = Int32.Parse(Console.ReadLine()); //hann inte fixa tryparse, så den crashar om man inte skriver nummer.
                    if (answer < 11 && answer > 0)
                    {
                        Console.Clear();
                        break;
                    } else {
                        Console.WriteLine("The answer has to be between 1-10");
                    }
                }

                while (true) {
                    Console.WriteLine("You will now be guessing the correct answer, choose a number between 1-10");
                    int guess = Int32.Parse(Console.ReadLine()); //hann inte fixa tryparse, så den crashar om man inte skriver nummer.
                    if (guess < 11 && guess > 0)
                    {
                        if (guess == answer)
                        {
                            Console.WriteLine("Hit!");
                            break;
                        }
                        else if (guess < answer+2 && guess > answer-2){
                            Console.WriteLine("Near miss!");
                        }
                        
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to continue? \n" + "Answer with either yes or no.");
                    string input = Console.ReadLine();
                    if (input == "yes") {
                        exit = true;
                        break;
                    } else if (input == "no") {
                        exit = false;
                        break;
                    } else {
                        Console.WriteLine("You need to answer with either yes or no.");
                    }
                }
                if (exit == true) {
                    break;
                }

            }
        }
    }
}
