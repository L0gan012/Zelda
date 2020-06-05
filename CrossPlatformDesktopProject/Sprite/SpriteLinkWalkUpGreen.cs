using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class SpriteLinkWalkUpGreen : ISprite
    {

        private Texture2D texture;
        private int currentFrame;
        private int totalFrames;
        private int currentTick;

        public SpriteLinkWalkUpGreen(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
            totalFrames = 2;
            currentTick = 0;
        }


        public void Update()
        {
            if (currentTick >= Constant.TicksPerFrameWalk)
            {
                currentTick = 0;
                currentFrame++;
                if (currentFrame >= totalFrames)
                    currentFrame = 0;
            }
            currentTick++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {

            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(144, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);
            }
            else
            {
                sourceRectangle = new Rectangle(160, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);
            }

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();


        }
    }
}
