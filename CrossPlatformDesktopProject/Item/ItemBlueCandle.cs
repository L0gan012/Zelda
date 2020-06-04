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
    public class ItemBlueCandle : IItem
    {
        //Instance variables
        private ISprite sprite;
        private Game1 game;

        private ItemBlueCandle(Game1 game)
        {
            this.game = game;
            //Load Blue Candle sprite
            sprite = ItemsSpriteFactory.Instance.CreateSpriteBlueCandle();
            game.ListOfItems.Add(this);
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            //Todo draw current item
            sprite.Draw(spriteBatch, texture);
        }


        public void Update()
        {
            
        }



    }
}
