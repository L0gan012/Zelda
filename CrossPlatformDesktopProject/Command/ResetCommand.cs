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
            //Initializes items objects
            Game1.Items = new List<IItem>();
            game.ItemLoader = new ItemLoadAllContent(game);
            this.game.ItemListPosition = 0;

            //Initializes enemy and npc objects
            Game1.Enemies = new List<INPC>();
            game.EnemyLoader = new EnemyLoadAllContent(game);
            this.game.EnemyListPosition = 0;


            //Initializes blocks object
            Game1.Blocks = new List<IBlock>();
            game.BlockLoader = new BlockLoadAllContent(game);
            this.game.BlockListPosition = 0;

            //Initializes player object
            game.Link = new Link(game);
        }
    }
}
