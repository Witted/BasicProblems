using System;

namespace RockPaperScissors
{
    public class Program
    {
        public static string playerChoice = "";        

        public static void Main(string[] args) {
            
            Dialog.getIntroDialog();

            var playerChoice = Console.ReadLine();
            
            while (GameState.gamesPlayed != GameState.numberOfGames)
            {
                Dialog.getPossibleMovesDialog();

                Dialog.getStatDialog();
                Dialog.getCountdownDialog();



                var opponantMove = PlayerInput.chooseOpponant(playerChoice);
                var playerMove = PlayerInput.PlayerMove();

                Console.WriteLine(opponantMove);

                WinConditions.assertWinner(playerMove, opponantMove);

                Console.Write("Hit Enter to continue.");
                Console.ReadLine();
                
            }
            Console.Write("Thanks for playing");
            Console.ReadLine();
        }
    }
}
