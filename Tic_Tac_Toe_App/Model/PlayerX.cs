using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_App.Model
{
    public class PlayerX : Player
    {

        public PlayerX(GameColor gameColor)  : base(gameColor)
        { }

        public override string ToString()
        {
            return "X";
        }

    }
}
