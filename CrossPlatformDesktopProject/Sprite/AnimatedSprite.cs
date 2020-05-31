using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    class AnimatedSprite : ISprite
    {
        //Instance variables
        private int currentFrame;
        private int totalFrames;
        private int framesPerSecond;

        private int locationX;
        private int locationY;

        //Constructor with window width and height
        public AnimatedSprite(int screenWidth, int screenHeight)
        {
            currentFrame = 1;
            totalFrames = 2;
            framesPerSecond = 60;

            locationX = screenWidth / 2;
            locationY = screenHeight / 2;
        }

        //Updates the current frame with respect to the total number of frames
        public void Update()
        {
            if(currentFrame % framesPerSecond == 0)
            {
                currentFrame = 1;
            } else
            {
                currentFrame++;
            }
        }

        //Draws the specified sprite to the screen
        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            //Dimensions for the specified sprites
            int spriteWidth = 14;
            int spriteHeight = 15;

            //Scale which the sprite is enlarged by
            int scale = 3;

            //Source and destination rectangles
            Rectangle sourceRectangle = new Rectangle();
            Rectangle destinationRectangle = new Rectangle(locationX - spriteWidth*scale/2, locationY - spriteHeight*scale/2, spriteWidth*scale, spriteHeight*scale);

            //Changes the source rectangle depending on the current frame
            spriteBatch.Begin();
            if (currentFrame <= framesPerSecond/totalFrames) {
                sourceRectangle = new Rectangle(74, 4, spriteWidth, spriteHeight);
            }
            else
            {
                sourceRectangle = new Rectangle(90, 4, spriteWidth, spriteHeight);
            }

            //Draws the specifed sprite to the screen
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
