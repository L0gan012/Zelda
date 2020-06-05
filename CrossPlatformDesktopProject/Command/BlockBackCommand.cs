using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    class BlockBackCommand : ICommand
    {
        //Instance variables
        private Game1 game;

        public BlockBackCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (this.game.blockListPosition > 0)
            {
                this.game.blockListPosition--;
            }

        }
    }
}
