using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RoshamboApp
    {
        public void BeginRoshambo()
        {
            UserPlayer user = new UserPlayer();

            bool goAgain = true;

            while (goAgain)
            {
                Console.Clear();
                Player opponent = ChooseOpponent();
                user.GenerateRoshambo();
                opponent.GenerateRoshambo();

                if (user.Winner(opponent))
                {
                    Console.WriteLine($"{user.ReturnName()} is the winner!");
                }
                else if (opponent.Winner(user))
                {
                    Console.WriteLine($"{opponent.ReturnName()} is the winner!");
                }
                else
                {
                    Console.WriteLine("Tie! Nobody wins!");
                }

                string quitChoice;
                Console.WriteLine($"You have a total of {user.Wins()} wins and {user.Losses()} losses.");
                Console.WriteLine("Enter (Q)uit to exit, or any other key to run again");

                quitChoice = Console.ReadLine().Trim();

                if (quitChoice.ToLower() == "q" || quitChoice.ToLower() == "quit")
                {
                    goAgain = false;
                   
                }
            }

        }


        public Player ChooseOpponent()
        {
            Console.WriteLine("Please choose opponent. 1. Rocky Robby or 2. Random Randy");
            int opponent = int.Parse(Console.ReadLine());

            if (opponent == 1)
            {
                return new Player1();
            }
            else if (opponent == 2)
            {
                return new Player2();
            }
            return ChooseOpponent();
        }



    }
}
