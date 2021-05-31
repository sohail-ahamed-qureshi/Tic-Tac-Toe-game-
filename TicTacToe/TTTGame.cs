using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TTTGame
    {
        //welcome message
        public void Welcome()
        {
            Console.WriteLine("~~~~~~TIC TAC TOE~~~~~~");
        }

        public void GameBoard()
        {
            //game board intilized with empty spaces and
            //zeroth index ignored
            char[] board = new char[10];
           
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }

            ////displaying game board for trail
            //foreach (char i in board)
            //{
            //    Console.WriteLine(i);
            //}
        }

        public void Display()
        {
           
        }
        
            



    }
}
