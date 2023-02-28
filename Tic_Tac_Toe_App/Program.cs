using System.Linq.Expressions;
using Tic_Tac_Toe_App.Model;

namespace Tic_Tac_Toe_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Board board = new Board(3,3);
            Match match = new Match();
            Canvas canvas = new Canvas();

            try
            {
                while (!match.matchIsFinished)
                {
                    try
                    {
                        //board.PlacePlayerAt(new Player(GameColor.Black), new Position(0, 0));
                        //board.PlacePlayerAt(new Player(GameColor.Black), new Position(0, 0));
                        Canvas.PrintBoard(match.board);
                        Console.WriteLine(match.numberOfPlaysLeft);
                        Console.WriteLine("Waiting for Player{0}", match.WhoIsPlaying());
                        Position pos = canvas.readPosition().ConvertToChessPosition();
                        match.MakeMove(pos);



                        Console.Clear();
                    }
                    catch (BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    Console.Clear();

                }


            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }
            Console.Clear();
        }
    }
}