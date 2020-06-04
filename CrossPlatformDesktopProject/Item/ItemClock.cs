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
    public class ItemClock : IItem
    {
        //Instance variables
        private ISprite sprite;
        private Game1 game;

        private ItemClock(Game1 game)
        {
            this.game = game;
            //Load Blue Candle sprite
            sprite = ItemsSpriteFactory.Instance.CreateSpriteClock();
            game.ListOfItems.Add(this);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Draw current item
            sprite.Draw(spriteBatch);
        }


        public void Update()
        {
            
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
