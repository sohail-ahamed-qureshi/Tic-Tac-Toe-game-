using System;

namespace TicTacToe
{
    class Program
    {/// <summary>
    /// UC5 - checking for empty spaces and checking for available spaces.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to TicTacToe game");
            TTTGame game = new TTTGame();
            game.Welcome();
            Console.WriteLine("");
           char[] board=  game.GameBoard();
            //loop till all empty spaces are filled
            for (int i = 1; i< board.Length; i++)
            {
                game.GameInput();
                game.ShowBoard(board);
                board = game.UserMove(board);
                game.ShowBoard(board);
            }
           

        }
    }
}
