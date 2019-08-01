using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player1 : Player
    {

        public Player1()
        {
            name = "Rocky Robby";
            roshambo = Roshambo.Rock;
        }

        public override Roshambo GenerateRoshambo()
        {
            return roshambo;
        }
    }
}
