using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part One
            //Ask the user for a starting number for the lowest number in the number range.
            //Ask the user for an ending number for the highest number in the number range.
            //Ask the user to guess the 6 numbers the user thinks will be the lucky numbers generated within the number range.
            //  -Numbers must be stored in an array
            //  -Array must be populated using a loop
            //If the user enters a number that is outside of the range set, prompt the user to give you a valid number. 
            //Do this until the user enters a valid number.

            string playAgain;
            double jackpotAmount = 10000000;
            Console.WriteLine("You can win up to ${0} if you can correctly guess some lucky numbers.\n\nSimply set a range of numbers by entering a minimum and maximum value.\n\nSix lucky numbers will then be selected at random from that range.\n\nYou can then guess six numbers and win money if they match the lucky numbers.\n\nIf you guess all six numbers you will win the whole pot!\n\n(Make sure your range is at least 6 numbers long as no numbers will be repeated)", jackpotAmount);
            do
            {
                Console.WriteLine("\nPlease enter the number that you would like to set as the range minimum.");
                int rangeMin = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number that you would like to set as the range maximum.");
                int rangeMax = int.Parse(Console.ReadLine());
                int[] guesses = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Enter a guess");
                    int guess = int.Parse(Console.ReadLine());
                    while (guess < rangeMin || guess > rangeMax)
                    {
                        Console.WriteLine("{0} is outside of the range\nPlease enter a number between {1} and {2}", guess, rangeMin, rangeMax);
                        guess = int.Parse(Console.ReadLine());
                    }
                    guesses[i] = guess;
                }

                //Part 2
                //The program should randomly generate 6 numbers using a loop
                //The randomly generated numbers should be stored in an array
                //Numbers should be displayed to the console as such and using a loop

                Console.WriteLine("\nThank you.\n\nThe Lucky Numbers are as follows:\n");
                Random random = new Random();
                int[] luckyNumbers = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    luckyNumbers[i] = random.Next(rangeMin, (rangeMax + 1));
                    if(i == 1)
                    {
                        while(luckyNumbers[i] == luckyNumbers[0])
                        {
                            luckyNumbers[i] = random.Next(rangeMin, (rangeMax + 1));
                        }
                    }
                    else if (i == 2)
                    {
                        while (luckyNumbers[i] == luckyNumbers[1] || luckyNumbers[i] == luckyNumbers[0])
                        {
                            luckyNumbers[i] = random.Next(rangeMin, (rangeMax + 1));
                        }
                    }
                    else if (i == 3)
                    {
                        while (luckyNumbers[i] == luckyNumbers[2] || luckyNumbers[i] == luckyNumbers[1] || luckyNumbers[i] == luckyNumbers[0])
                        {
                            luckyNumbers[i] = random.Next(rangeMin, (rangeMax + 1));
                        }
                    }
                    else if (i == 4)
                    {
                        while (luckyNumbers[i] == luckyNumbers[3] || luckyNumbers[i] == luckyNumbers[2] || luckyNumbers[i] == luckyNumbers[1] || luckyNumbers[i] == luckyNumbers[0])
                        {
                            luckyNumbers[i] = random.Next(rangeMin, (rangeMax + 1));
                        }
                    }
                    else if (i == 5) 
                    {
                        while (luckyNumbers[i] == luckyNumbers[4] || luckyNumbers[i] == luckyNumbers[3] || luckyNumbers[i] == luckyNumbers[2] || luckyNumbers[i] == luckyNumbers[1] || luckyNumbers[i] == luckyNumbers[0])
                        {
                            luckyNumbers[i] = random.Next(rangeMin, (rangeMax + 1));
                        }
                    }
                    Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
                }
                
                //Part 3
                //Hard-code a value for the jackpot amount and let the user know what the jackpot amount is at some point you decide in the program.
                //The program should count the number of correctly guessed numbers and output to the console to notify the user.
                //Example:You guessed 3 numbers correctly!
                //The program should calculate the user's winnings based on the number of numbers guessed correctly.
                //The user's winnings should be output to the console. 
                //Example: You won $256,877.23!
                
                int correctGuesses = 0;
                foreach (int guess in guesses)
                {
                    if (guess == luckyNumbers[0] || guess == luckyNumbers[1] || guess == luckyNumbers[2] || guess == luckyNumbers[3] || guess == luckyNumbers[4] || guess == luckyNumbers[5])
                    {
                        correctGuesses += 1;
                    }
                }
                if(correctGuesses == 1)
                {
                    Console.WriteLine("\nYou guessed {0} number correctly!", correctGuesses);
                }
                else
                Console.WriteLine("\nYou guessed {0} numbers correctly!", correctGuesses);
                //added above if else to avoid the console printing "You guessed 1 numbers correctly!"
                double winnings = Math.Round((jackpotAmount / 6) * correctGuesses, 2);
                Console.WriteLine("\nYou won $" + winnings);

                // Ask the user if the user would like to play again.
                //If the user says yes, then the program should run again from the beginning.
                //If the user says no, then the program should say "Thanks for playing!"(Must be exact statement).
                //Use do-while loop
                Console.WriteLine("\nWould you like to play again? Yes/No");
                playAgain = Console.ReadLine().ToLower();
            }
            while (playAgain == "yes");

            //added stretch task 
            //if user picks a range that is smaller than 6, they get stuck in a loop. 
            //Couldn't figure out how to get around it so added a line instructing the user to make sure their range was big enough.


        }
    }
}
