using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{

        class UserPlayer : Player
        {
            public UserPlayer()
            {
            
            }

            public override Roshambo GenerateRoshambo()
            {

            int userChoice = int.Parse(Program.GetUserInput("Choose 1.Rock 2.Paper 3.Scissors"));

            if (userChoice > 0 && userChoice < 4)
            {
                roshambo = (Roshambo)userChoice;
            }
            else
            {
                Console.WriteLine("Not a valid input. Please enter a number 1-3.");
                return GenerateRoshambo();
            }
            return roshambo;
            
            
            }
        }



    
}
