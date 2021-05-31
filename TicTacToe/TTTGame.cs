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

        public char[] GameBoard()
        {
            //game board intilized with empty spaces and
            //zeroth index ignored
            char[] board = new char[10];

            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        //tossing for players
        public int Toss()
        {
            Random random = new Random();
            int rand = random.Next(2);
            if (rand == 0)
            {
                Console.WriteLine("Computer plays first");
                Console.WriteLine("computer inputs 'x' ");
            }
            if (rand == 1)
            {
                Console.WriteLine("Player plays first");
                Console.WriteLine("player inputs 'o' ");
            }
            return rand;
        }

        //displaying game board
        public void ShowBoard(char[] board)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {board[1]} | {board[2]} | {board[3]}");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {board[4]} | {board[5]} | {board[6]}");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {board[7]} | {board[8]} | {board[9]}");
            Console.WriteLine("   |   |   ");
        }
        //user making his move
        public char[] UserMove(char[] board)
        {
            Console.WriteLine("select the location on Board :  ");
            int location = Convert.ToInt32(Console.ReadLine());
            //validating user location
            while (location > 9 || location < 1)
            {
                Console.WriteLine("invalid location, select the location on Board :  ");
                location = Convert.ToInt32(Console.ReadLine());
            }
            //loop to check for empty space
            bool one = false;
            while (true)
            {
                //checking for free space
                location = CheckBoard(location, board);
                if (location == 0)
                {
                    Console.WriteLine("location already selected");
                    Console.WriteLine("select another location on Board :  ");
                    location = Convert.ToInt32(Console.ReadLine());
                    one = true;
                }
                else
                {
                    board[location] = 'x';
                    break;
                }
            }
            return board;
        }

        //checking if board is empty
        public int CheckBoard(int location, char[] board)
        {
            if(board[location] != ' ')
            {
                return 0;
            }
            else
            {
                return location;
            }
        }

        public void GameInput()
        {
            //randomly selecting who plays first
            // and assign character x and o
            Toss();

        }
    }
}
