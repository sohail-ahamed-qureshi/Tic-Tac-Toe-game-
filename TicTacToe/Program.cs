using System;

namespace TicTacToe
{
    class Program
    {/// <summary>
    /// UC6 - Check who plays first.
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
            for (int i = 1; i< board.Length; i++)
            {
                board = game.UserMove(board, player);
                game.ShowBoard(board);
            }
           

        }
    }
}
