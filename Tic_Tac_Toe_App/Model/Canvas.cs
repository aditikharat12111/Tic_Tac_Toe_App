using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_App.Model
{
    public class Canvas
    {
        public static void PrintBoard(Board b)
        {
            Console.WriteLine("3" + "  {0}     |     {1}   |    {2}  ", b.board[0,0], b.board[0,1], b.board[0,2]);
            Console.WriteLine("    ----------------------- ");
            Console.WriteLine("2" + "  {0}     |     {1}   |    {2}  ", b.board[1, 0], b.board[1, 1], b.board[1, 2]);
            Console.WriteLine("    ----------------------- ");
            Console.WriteLine("1" + "  {0}     |     {1}   |    {2}  ", b.board[2, 0], b.board[2, 1], b.board[2, 2]);
            Console.WriteLine("    ----------------------- ");
            Console.WriteLine("      a        b        c   ");

        }
        
        public ChessPosition readPosition()
        {
            string s = Console.ReadLine();
            char row = s[0];
            int column = int.Parse(s[1] + "");

            

            return new ChessPosition(row, column);
        }

    }
}
