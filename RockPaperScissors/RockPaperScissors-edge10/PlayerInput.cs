using System;
using RockPaperScissors.Players;

namespace RockPaperScissors
{
    public class PlayerInput
    {
        public static Moves PlayerMove()
        {            
            try
            {
                var possibleMoves = new MoveHierachy().MoveList();

                // get the players move
                var choice = Console.ReadLine().ToLower();

                Moves move = (Moves)Enum.Parse(typeof(Moves), choice);               

               return move;
            }
            catch
            {
                var possibleMove = "";
                foreach (Moves x in Enum.GetValues(typeof(Moves)))
                {
                    possibleMove += x + " ";
                }

                Console.WriteLine("Did not recognise the move, please try again");
                Console.WriteLine(String.Format("Here is the list of possible moves: {0}", possibleMove));

                Moves move = PlayerMove();
                return move;                
            }
        }
        public static Moves chooseOpponant(string choice)
        {
            Moves opponantMove = RandomPlayer.makeRandomMove();           
            

            if (choice == "1")
            {
                opponantMove = RandomPlayer.makeRandomMove();
            }
            else if (choice == "2")
            {
                opponantMove = TacticalPlayer.getTacticalMove();
            }
            else
            {
                Console.WriteLine("Did not recognise input, please try again");
                var choose = Console.ReadLine();
                chooseOpponant(choose);
            }

            return opponantMove;

        }
    }
}
