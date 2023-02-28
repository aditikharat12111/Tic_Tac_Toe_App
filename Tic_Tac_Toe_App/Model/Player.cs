using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_App.Model
{
    public class Player
    {
        public Position position;
        public GameColor gameColor;

        public Player(GameColor color)
        {
            position = null;
            gameColor = color;
        }

       
    }
}
