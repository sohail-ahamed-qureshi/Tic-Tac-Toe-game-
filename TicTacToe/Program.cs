using System;

namespace TicTacToe
{
    class Program
    {/// <summary>
    /// UC7 - Check who for winner.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to TicTacToe game");
            TTTGame game = new TTTGame();
            game.Welcome();
            Console.WriteLine("");
           char[] board=  game.GameBoard();
            TTTGame.Player player = game.GameInput();
            game.ShowBoard(board);
            //loop till all empty spaces are filled
            for (int i = 1; i < board.Length; i++)
            {
                if(game.getCheckwin() == true)
                {
                    break;
                }
                board = game.Turn(board, player);
                game.ShowBoard(board);
                
            }
           


        }
    }
}
