using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class GameState
    {
        public static int numberOfGames = 3;
        public static int gamesPlayed = 0;

        public static int playerScore = 0;
        public static int opponantScore = 0;

        public void resetGame()
        {
            playerScore = 0;
            opponantScore = 0;
        }

        public static void playerWon()
        {
            playerScore += 1;
        }

        public static void playerLost()
        {
            opponantScore += 1;
        }
    }
}
