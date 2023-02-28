using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_App.Model
{
    public class ChessPosition
    {
        char column { get; set; }
        int row { get; set; }   

        public ChessPosition(char column, int row)
        {
            this.column = column;
            this.row = row;
                
        }

        public Position ConvertToChessPosition()
        {
            return new Position(3- row, column - 'a');
        }
    }
}
