using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to TicTacToe game");
            TTTGame game = new TTTGame();
            game.Welcome();
            Console.WriteLine();
            game.GameBoard();
        }
    }
}
