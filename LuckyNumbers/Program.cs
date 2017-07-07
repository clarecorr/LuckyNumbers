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

            Console.WriteLine("Please enter the number that you would like to set as the low end of the range.");
            int rangeMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number that you would like to set as the high end of the range.");
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

            Random random = new Random();
            int[] luckyNumbers = new int[6];
            for (int i = 0; i < 6; i++)
            {
                luckyNumbers[i] = random.Next(rangeMin, (rangeMax + 1));
                Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
            }


            //Part 3
            //Hard-code a value for the jackpot amount and let the user know what the jackpot amount is at some point you decide in the program.
            //The program should count the number of correctly guessed numbers and output to the console to notify the user.
            //Example:You guessed 3 numbers correctly!
            //The program should calculate the user's winnings based on the number of numbers guessed correctly.
            //The user's winnings should be output to the console. 
            //Example: You won $256,877.23!

            double jackpotAmount = 10000000;
            int correctGuesses = 0;
            foreach (int guess in guesses)
            {
                if (guess == luckyNumbers[0] || guess == luckyNumbers[1] || guess == luckyNumbers[2] || guess == luckyNumbers[3] || guess == luckyNumbers[4] || guess == luckyNumbers[5])
                {
                    correctGuesses += 1;
                }
            }
            Console.WriteLine("You guessed {0} numbers correctly!", correctGuesses);
            double winnings = (jackpotAmount / 6) * correctGuesses;
            Console.WriteLine("You won $" + winnings);






        }
    }
}
