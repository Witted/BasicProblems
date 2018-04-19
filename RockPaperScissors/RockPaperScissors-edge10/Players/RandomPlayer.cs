using System;

namespace RockPaperScissors.Players
{
    public class RandomPlayer
    {
        /// <summary>
        /// Player that will make random moves
        /// </summary>
        public static Moves makeRandomMove() {

            Random random = new Random();
            var moves = Enum.GetValues(typeof (Moves));

            var move = (Moves)moves.GetValue(random.Next(0, moves.Length));

            return move;
        }
    }
}
