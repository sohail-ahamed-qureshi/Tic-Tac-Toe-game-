using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TTTGame
    {
        const int HEADS = 1;
        const int TAILS = 0;
        bool checkWin=false;
        int numOfTurns = 0;
        public enum Player { USER, COMPUTER};
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
        private static int Toss()
        {
            Random random = new Random();
            int rand = random.Next(2);
            if (rand == HEADS)
            {
                Console.WriteLine("Computer plays first");
                Console.WriteLine("computer inputs 'X' ");
                return HEADS;
            }
            if (rand == TAILS)
            {
                Console.WriteLine("Player plays first");
                Console.WriteLine("player inputs 'O' ");
                return TAILS;
            }
            return 0;
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

        public char[] Turn(char[] board, Player player)
        {
            int turn = 1;
            char ch;
            while (true )
            {
                //check fot wins
                if (checkWin == true)
                {
                    Console.WriteLine($"{player} Wins!!");
                    break;
                }
                //player 1's turn
                if (turn == 1)
                {
                    Console.WriteLine($"{player}'s turn");
                    ch = 'X';
                   board = UserMove(board, player ,ch);
                    ShowBoard(board);
                    turn = 0;
                    numOfTurns++; // to count for tie
                }
                //check for win for player 2
                if (checkWin == true)
                {
                    Console.WriteLine($"{player + 1} Wins!!");
                    break;
                }
                //player 2's turn
                if (turn == 0)
                {
                    Console.WriteLine($"{player + 1}'s turn");
                    ch = 'O';
                    board = UserMove(board, player,ch);
                    ShowBoard(board);
                    turn = 1;
                    numOfTurns++;
                }
            }
            return board;
        }
        //user making his move
        public char[] UserMove(char[] board, Player player, char ch)
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
                if (player == Player.USER)
                {
                    board[location] = ch;
                    checkWin = CheckWin(board, board[location]);
                    break;
                }
                
                if (player == Player.COMPUTER)
                {
                    board[location] = ch;
                    checkWin = CheckWin(board, board[location]);
                    break;
                }
                if (numOfTurns == 9 && checkWin == false)
                {
                    Console.WriteLine("its a tie");
                    break;
                }
            }
            return board;
        }

        public bool getCheckwin()
        {
            return checkWin;
        }
      

        public bool CheckWin(char [] b, char ch)
        {
            if (b[1] == ch && b[2] == ch && b[3] == ch)//top
                return true;
            if (b[4] == ch && b[5] == ch && b[6] == ch)//middle
                return true;
            if (b[7] == ch && b[8] == ch && b[9] == ch)//bottom
                return true;
            if (b[1] == ch && b[4] == ch && b[7] == ch)//left
                return true;
            if (b[2] == ch && b[5] == ch && b[8] == ch)//middle
                return true;
            if (b[3] == ch && b[6] == ch && b[9] == ch)//right
                return true;
            if (b[1] == ch && b[5] == ch && b[9] == ch)//diagonal
                return true;
            if (b[3] == ch && b[5] == ch && b[7] == ch)//diagonal
                return true;
            return false;
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

        public Player GameInput()
        {
            //randomly selecting who plays first
            // and assign character x and o
           
           int playerSel = Toss();
            Player player;
            if(playerSel == HEADS)
            {
                return player = Player.COMPUTER;
            }
            else
                return player = Player.USER;

  
        }
    }
}
