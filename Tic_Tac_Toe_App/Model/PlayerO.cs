using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_App.Model
{
    public class PlayerO : Player
    {

        public PlayerO(GameColor gameColor) : base(gameColor)
        { }

        public override string ToString()
        {
            return "O";
        }

    }
}
