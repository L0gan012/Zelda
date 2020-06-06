using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    /// <summary>
    /// Command to move player right
    /// </summary>
    class SetIdleCommand : ICommand
    {
        //Instance variables
        private Game1 game;

        public SetIdleCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            //method yet to be written
            this.game.Link.SetIdle();
        }
    }
}