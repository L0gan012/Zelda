using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Isabel Smith
namespace Sprint2.Command
{
    /// <summary>
    /// Command to move player down
    /// </summary>
    class MoveDownCommand : ICommand
    {
        //Instance variables
        private Game1 game;

        public MoveDownCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            this.game.Link.MoveDown();
        }
    }
}