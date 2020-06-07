using System;
using System.Collections.Generic;
using Sprint2.Enemy_NPC;
using Sprint2.Item;


namespace Sprint2
{
    public class ResetCommand : ICommand
    {
        private Game1 game;

        //Constructor with game instance parameter
        public ResetCommand(Game1 game)
        {
            this.game = game;
            
        }

        //Exits the game
        public void Execute()
        {
            this.game.ItemListPosition = 0;

            this.game.EnemyListPosition = 0;

            this.game.BlockListPosition = 0;
        }
    }
}
