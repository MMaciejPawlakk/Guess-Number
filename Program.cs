using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int guess = 0;

            while (run)
            {
                int winningNumber = getNumber();
                int numberOfGuesses = 1;

                Console.WriteLine("I'm thinking of a random number from 1 to 100 \n\n Can you guess that number?");
                guess = makeGuess();

                while (numberOfGuesses < 6)
                {
                    if (guess == winningNumber)
                    {
                        Console.WriteLine("You have won!");
                        break;
                    }
                    else if (guess < winningNumber)
                    {
                        Console.WriteLine("You guessed wrong. My number is bigger thank yours. TRY AGAIN.");
                        guess = makeGuess();
                        numberOfGuesses++;
                    }
                    else
                    {
                        Console.WriteLine("You guessed wrong. My number is smaller than yours. TRY AGAIN.");
                        guess = makeGuess();
                        numberOfGuesses++;
                    }
                }
                if (guess == winningNumber && numberOfGuesses == 6)
                {
                    Console.WriteLine("You have won!");
                    run = playAgain();
                }
                else if(guess == winningNumber && numberOfGuesses < 6)
                {
                    run = playAgain();
                }
                else
                {
                    Console.WriteLine("You have lost. The correct number was {0} \n\n", winningNumber);
                    run = playAgain();
                }
            }

            Console.Clear();
            Console.WriteLine("Thank you for playing! \n\nGood bye :)");
            Console.ReadLine();
        }

        static int getNumber()
        {
            Random genericNumber = new Random();
            int randomNumber = genericNumber.Next(1, 101);
            return randomNumber;

        }

        static bool playAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n) \n\n");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "YES" || answer.ToUpper() == "Y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        static int makeGuess()
        {
            int myguess = 0;
            try
            {
                myguess = Convert.ToInt32(Console.ReadLine());
                return myguess;
            }
            catch (Exception ex)
            {
                Console.WriteLine("You have to write a number you idiot.");

                return myguess;
            }
        }

       
    }
}
