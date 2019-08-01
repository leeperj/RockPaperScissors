using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{

    enum Roshambo
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }
    abstract class Player
    {
        protected string name;
        protected Roshambo roshambo;
        private int winCount;
        private int lossCount;
        private int tieCount;
        public Player()
        {

        }

        public abstract Roshambo GenerateRoshambo();

        public bool Winner(Player player)
        {
            if(this.roshambo == player.roshambo)
            {
                tieCount++;
                return false;
            }
            else if(this.roshambo == Roshambo.Rock && player.roshambo == Roshambo.Scissors)
            {
                winCount++;
                return true;
            }
            else if(this.roshambo == Roshambo.Paper && player.roshambo == Roshambo.Rock)
            {
                winCount++;
                return true;
            }
            else if(this.roshambo == Roshambo.Scissors && player.roshambo == Roshambo.Paper)
            {
                winCount++;
                return true;
            }

            lossCount++;
            return false;
        }

        public string ReturnName()
        {
            return name;
        }
        public int Wins()
        {
            return winCount;
        }
        public int Losses()
        {
            return lossCount;
        }
        public int Ties()
        {
            return tieCount;
        }
        
    }
    
}
