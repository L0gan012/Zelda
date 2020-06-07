using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Item
{
    /// <summary>
    /// Class to load all items to games item list
    /// </summary>
    public class ItemLoadAllContent
    {
        //Instance variables
        Game1 game;
        
        public ItemLoadAllContent(Game1 game)
        {
            this.game = game;
        }

        //Initailizes all game items
        public void LoadContent()
        {
            game.ListOfItems.Add(new ItemBlueCandle());
            game.ListOfItems.Add(new ItemBluePotion());
            game.ListOfItems.Add(new ItemBlueRing());
            game.ListOfItems.Add(new ItemBomb());
            game.ListOfItems.Add(new ItemBow());
            game.ListOfItems.Add(new ItemClock());
            game.ListOfItems.Add(new ItemCompass());
            game.ListOfItems.Add(new ItemFairy());
            game.ListOfItems.Add(new ItemFiveRupee());
            game.ListOfItems.Add(new ItemFlute());
            game.ListOfItems.Add(new ItemHeartContainer());
            game.ListOfItems.Add(new ItemKey());
            game.ListOfItems.Add(new ItemLadder());
            game.ListOfItems.Add(new ItemMagicBoomerang());
            game.ListOfItems.Add(new ItemMagicRod());
            game.ListOfItems.Add(new ItemMagicShield());
            game.ListOfItems.Add(new ItemMap());
            game.ListOfItems.Add(new ItemPotionNote());
            game.ListOfItems.Add(new ItemPowerBracelet());
            game.ListOfItems.Add(new ItemRaft());
            game.ListOfItems.Add(new ItemRedPotion());
            game.ListOfItems.Add(new ItemRupee());
            game.ListOfItems.Add(new ItemSilverArrow());
            game.ListOfItems.Add(new ItemWhiteSword());
            game.ListOfItems.Add(new ItemWoodenArrow());
        }
    }
}
