﻿ using Microsoft.Xna.Framework;
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
        private Vector2 location;
        private Color color;
        public ItemClock()
        {

            //Load Clock sprite
            sprite = ItemsSpriteFactory.Instance.CreateSpriteClock();
            location = Constant.ItemStartPosition;
            color = Color.White;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Draw current item
            sprite.Draw(spriteBatch, color, location);
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
