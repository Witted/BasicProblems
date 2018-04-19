using System;

namespace RockPaperScissors
{
    public class Dialog
    {
        public static void getIntroDialog()
        {
            Console.WriteLine("Welcome to good old rock paper scissors!");
            Console.WriteLine("Pick a foe:");
            Console.WriteLine("Enter '1' for random player");
            Console.WriteLine("Enter '2' for tactical player");
        }

        public static void getPossibleMovesDialog()
        {
            Console.WriteLine("Here is your list of possible moves: ");

            var moves = Enum.GetValues(typeof(Moves));
            foreach (var move in moves)
            {
                Console.WriteLine(move);
            }
        }

        public static void getStatDialog()
        {
            Console.WriteLine(String.Format("Your score: {0}, Opponants score: {1}", GameState.playerScore, GameState.opponantScore));

        }       

        public static void getCountdownDialog()
        {
            Console.WriteLine("Lets begin in:");
            Console.WriteLine("3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
