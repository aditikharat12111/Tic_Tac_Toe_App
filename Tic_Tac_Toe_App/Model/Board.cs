using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_App.Model
{
    public class Board
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string[,] board;

        public Board(int rows, int columns)
        {
            this.Row = rows;
            this.Column = columns;
            board = new string[rows, columns];
        }

        public string BoardPosition(Position pos)
        {
            InsideOfBoard(pos);
            return board [pos.Row, pos.Column];
        }


        public string  BoardPos(int rows, int columns) 
        {
            return board[rows, columns];
        }

        public bool positionIsOccupied(Position position)
        {
            return BoardPosition(position) != null;
        }

        public void PlacePlayerAt(Player player, Position pos)
        {
            if (positionIsOccupied(pos))
            {
                throw new Exception("There is already a player in this position ");
            }

            board[pos.Row, pos.Column] = player.ToString();
            player.position = pos;

        }

        public bool IsOutOfBoard(Position pos)
        {
            if(pos.Row<0 || pos.Row>= Row || pos.Column <0 || pos.Column >= Column)
                return false;
            return true;
        }

        public void InsideOfBoard(Position pos)
        {
            if (!IsOutOfBoard(pos))
            {
                throw new BoardException("Position is out of board");
            }
        }
    }
}
