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
        }

        //tossing for players
        public int Toss()
        {
            Random random = new Random();
            int rand = random.Next(2);
            if(rand == 0)
            {
                Console.WriteLine("Computer plays first");
                Console.WriteLine("computer inputs 'x' ");
            }
            if(rand == 1)
            {
                Console.WriteLine("Player plays first");
                Console.WriteLine("player inputs 'o' ");
            }
            return rand;
        }

        public void GameInput()
        {
           //randomly selecting who plays first
           // and assign character x and o
           Toss();

        }
        
            



    }
}
