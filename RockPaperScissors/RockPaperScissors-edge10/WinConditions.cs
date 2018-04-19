using System;

namespace RockPaperScissors
{
    public class WinConditions
    {
        public static void assertWinner(Moves playerMove, Moves opponantMove)
        {
            var possibleMoves = new MoveHierachy().MoveList();
            foreach (var move in possibleMoves)
            {
                if (move.moveName == playerMove && move.moveBeats.Contains(opponantMove))
                {
                    Console.WriteLine("You won the round!");
                    GameState.playerScore += 1;
                    GameState.gamesPlayed++;
                    break;
                }
                else if (move.moveName == opponantMove && move.moveBeats.Contains(playerMove))
                {
                    Console.WriteLine("You lost the round. Bad Luck");
                    GameState.opponantScore += 1;
                    GameState.gamesPlayed++;
                    break;
                }
                else if(move.moveName == opponantMove && move.moveName == playerMove)
                {
                    Console.WriteLine("Draw! Rematch!");
                    break;
                } 
            }
        }
    }
}
