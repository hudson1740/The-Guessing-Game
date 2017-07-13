using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int PlayerGuess;
            string PlayerInput;
            bool isNumberGuessed = false;
            int TheAnswer;
            Random rng = new Random();
            TheAnswer = rng.Next(1, 21);

            do
            {
                Console.Write("Enter Your Guess: ");
                PlayerInput = Console.ReadLine();

                PlayerGuess = int.Parse(PlayerInput);

                if (PlayerGuess == TheAnswer)
                {
                    Console.WriteLine("YOU WON ! ! !");
                    isNumberGuessed = true;
                }
                else
                {
                    if (PlayerGuess > TheAnswer)
                    {
                        Console.WriteLine("To High");
                    }
                    else
                    {
                        Console.WriteLine("To Low");
                    }

                }

            } while (!isNumberGuessed);
            Console.ReadLine();
        }
    }
}
