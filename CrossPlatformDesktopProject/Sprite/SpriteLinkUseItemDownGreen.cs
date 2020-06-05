﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    public class SpriteLinkUseItemDown : ISprite
    {
        private Texture2D texture;

        public SpriteLinkUseItemDown(Texture2D texture)
        {
            this.texture = texture;
        }


        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            sourceRectangle = new Rectangle(640, 16, 16, 16);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

            spriteBatch.Begin();
            spriteBatch.Draw(this.texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }


        public void Update()
        {

        }
    }
}

