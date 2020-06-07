using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    /// <summary>
    /// Command to change item on display
    /// </summary>
    class ItemFowardCommand : ICommand
    {
        //Instance variables
        private Game1 game;

        public ItemFowardCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (this.game.ItemListPosition < this.game.ListOfItems.Count - 1) 
            { 
                this.game.ItemListPosition++; 
            }
           
        }
    }
}