using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player2 : Player
    {
        
        public Player2()
        {
            name = "Random Randy";
            
        }

        public override Roshambo GenerateRoshambo()
        {
            roshambo = (Roshambo)new Random().Next(3)+1;
            return roshambo;
        }
        
    }
}
