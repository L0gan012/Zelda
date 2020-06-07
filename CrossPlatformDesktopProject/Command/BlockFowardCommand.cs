using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    class BlockFowardCommand : ICommand
    {

        //Instance variables
        private Game1 game;

        public BlockFowardCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (this.game.BlockListPosition < this.game.ListOfBlocks.Count - 1)
            {
                this.game.BlockListPosition++;
            }

        }
    }
}
