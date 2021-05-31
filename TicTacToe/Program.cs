using System;

namespace TicTacToe
{
    class Program
    {/// <summary>
    /// UC4 - making user to place empty places on board.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to TicTacToe game");
            TTTGame game = new TTTGame();
            game.Welcome();
            Console.WriteLine("");
           char[] board=  game.GameBoard();
            game.GameInput();
            game.ShowBoard(board);
           board =  game.UserMove(board);
            game.ShowBoard(board);

        }
    }
}
