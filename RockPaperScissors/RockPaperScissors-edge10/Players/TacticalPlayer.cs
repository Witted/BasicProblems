using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Players
{
    /// <summary>
    /// Tactical player will always choose the move that beats its last choice
    /// </summary>
    public class TacticalPlayer
    {
        private static bool hasPreviousMove = false;
        private static Moves previousMove;

        public static Moves getTacticalMove()
        {
            Moves move;

            if (hasPreviousMove)
            {
                // Gets list of moves
                var moveslist = new MoveHierachy();
                List<newMove> moves = moveslist.MoveList();

                move = moves.Where(x => x.moveBeats.Contains(previousMove)).First().moveName;
                previousMove = move;
            }
            else
            {
                var moves = Enum.GetValues(typeof(Moves));

                move = (Moves)moves.GetValue(new Random().Next(moves.Length));

                previousMove = move;
                hasPreviousMove = true;
            }
            return move;
        }        
    }
}
