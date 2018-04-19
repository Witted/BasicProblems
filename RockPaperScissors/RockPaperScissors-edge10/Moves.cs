using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{    
    public enum Moves
    {
        rock,
        paper,
        scissors
    }

    public class MoveHierachy
    {
        public List<newMove> moves;

        /// <summary>
        /// A list to show which move beats which
        /// </summary>
        public List<newMove> MoveList()
        {
            moves = new List<newMove>
            {
                new newMove(Moves.rock, new List<Moves>{ Moves.scissors }),
                new newMove(Moves.paper,new List<Moves>{ Moves.rock }),
                new newMove(Moves.scissors,new List<Moves>{ Moves.paper })
            };

            return moves;
        }
    }

    /// <summary>
    /// Structure for creation of a move
    /// </summary>
    public struct newMove
    {
        public Moves moveName;

        public List<Moves> moveBeats;

        public newMove(Moves move, List<Moves> beats)
        {
            moveName = move;
            moveBeats = beats;
        }

    }



}
