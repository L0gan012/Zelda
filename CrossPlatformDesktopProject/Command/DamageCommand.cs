using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    class DamageCommand : ICommand
    {
        //Instance variables
        private Game1 game;
 
        public DamageCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            this.game.link.DamagePlayer();
        }
    }
}
