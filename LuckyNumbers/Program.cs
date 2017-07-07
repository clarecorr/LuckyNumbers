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
                while(guess < rangeMin|| guess > rangeMax)
                {
                    Console.WriteLine("{0} is outside of the range\nPlease enter a number between {1} and {2}", guess, rangeMin, rangeMax);
                    guess = int.Parse(Console.ReadLine());
                }
                guesses[i] = guess;
            }

           //



        }
    }
}
