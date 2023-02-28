using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_App.Model
{
    
    public class Match
    {

        public  Board board{get; set;}
        public GameColor currentPlayer;
        public int numberOfPlaysLeft = 9;
        public bool matchIsFinished = false;
        public Match()
        {
            board = new Board(3, 3);
            currentPlayer = GameColor.Black;
        }
        public void ChangePlayer()
        {
            if(currentPlayer==GameColor.Black)
            {
                currentPlayer = GameColor.White;
            }
            else
            {
                currentPlayer = GameColor.Black;
           
            }
        }

        public void CheckWinner()
        {
            if(board.BoardPos(0,0) != null)
            {
                if (board.board[0, 0] == board.board[0, 1] && board.board[0, 1] == board.board[0, 2])
                {
                    Console.WriteLine("Winner : " + board.board[0,0]);
                    Console.Read();
                    matchIsFinished = true;
                }
            }

            if (board.BoardPos(1, 0) != null)
            {
                if (board.board[1, 0] == board.board[1, 1] && board.board[1, 1] == board.board[1, 2])
                {
                    Console.WriteLine("Winner : " + board.board[1, 0]);
                    Console.Read();
                    matchIsFinished = true;
                }
            }

            if (board.BoardPos(2, 0) != null)
            {
                if (board.board[2, 0] == board.board[2, 1] && board.board[2, 1] == board.board[2, 2])
                {
                    Console.WriteLine("Winner : " + board.board[2, 0]);
                    Console.Read();
                    matchIsFinished = true;
                }
            }

            if (board.BoardPos(0, 0) != null)
            {
                if (board.board[0, 0] == board.board[1, 0] && board.board[2, 1] == board.board[2, 2])
                {
                    Console.WriteLine("Winner : " + board.board[0, 0]);
                    Console.Read();
                    matchIsFinished = true;
                }
            }


            if (board.BoardPos(0, 1) != null)
            {
                if (board.board[0, 1] == board.board[1, 1] && board.board[1, 1] == board.board[2, 1])
                {
                    Console.WriteLine("Winner : " + board.board[0, 1 ]);
                    Console.Read();
                    matchIsFinished = true;
                }
            }


            if (board.BoardPos(0, 2) != null)
            {
                if (board.board[0, 2] == board.board[1, 2] && board.board[1, 2] == board.board[2, 2])
                {
                    Console.WriteLine("Winner : " + board.board[0, 2]);
                    Console.Read();
                    matchIsFinished = true;
                }
            }


            if (board.BoardPos(0, 2) != null)
            {
                if (board.board[0, 2] == board.board[1, 1] && board.board[1, 1] == board.board[2, 2])
                {
                    Console.WriteLine("Winner : " + board.board[0, 2]);
                    Console.Read();
                    matchIsFinished = true;
                }
            }


            if (board.BoardPos(0, 2) != null)
            {
                if (board.board[0, 2] == board.board[1, 1] && board.board[1, 1] == board.board[2, 0])
                {
                    Console.WriteLine("Winner : " + board.board[0, 2]);
                    Console.Read();
                    matchIsFinished = true;
                }
            }

            if(numberOfPlaysLeft == 0)
            {
                Console.WriteLine("Tie");
                matchIsFinished= true;
            }


        }

        public Player WhoIsPlaying() 
        { 
            if(currentPlayer == GameColor.Black)
            {
                return new PlayerO(GameColor.Black);    
            }
            else
            {
                return new PlayerX(GameColor.Black);
            }
        }

        public void MakeMove(Position movePosition)
        {
            CheckWinner();
            board.PlacePlayerAt(WhoIsPlaying(), movePosition);
            numberOfPlaysLeft--;
            ChangePlayer();
        }
    }
}
