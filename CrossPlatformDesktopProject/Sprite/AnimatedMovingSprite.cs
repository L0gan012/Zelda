using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    class AnimatedMovingSprite : ISprite
    {
        //Instance variables
        private int currentFrame;
        private int totalFrames;
        private int framesPerSecond;
        Texture2D texture;
        private int locationX;
        private readonly int screenWidth;
        private readonly int screenHeight;



        //Constructor with window height and width
        public AnimatedMovingSprite(int screenWidth, int screenHeight, Texture2D texture)
        {
            currentFrame = 1;
            totalFrames = 2;
            framesPerSecond = 60;
            this.texture = texture;
            locationX = screenWidth;
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
        }

        //Updates the current frame and position
        public void Update()
        {
            if (currentFrame % framesPerSecond == 0)
            {
                currentFrame = 1;
            }
            else
            {
                currentFrame++;
            }

            if (locationX <= 0)
            {
                locationX = screenWidth;
            }
            else
            {
                locationX -= 2;
            }
        }

        //Draws the sprite to the screen
        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            //Dimensions of the sprites
            int spriteWidth = 16;
            int spriteHeight = 16;

            //Scale by with the sprite is enlarged by
            int scale = 3;

            //Source and destination rectangles
            Rectangle sourceRectangle = new Rectangle();
            Rectangle destinationRectangle = new Rectangle(locationX, this.screenHeight/2 - spriteHeight*scale/2, spriteWidth * scale, spriteHeight * scale);

            //Changes the source rectangle based on the current frame
            spriteBatch.Begin();
            if(currentFrame <= framesPerSecond / totalFrames)
            {
                sourceRectangle = new Rectangle(100, 52, spriteWidth, spriteHeight);
            }
            else
            {
                sourceRectangle = new Rectangle(118, 52, spriteWidth, spriteHeight);
            }
            spriteBatch.Draw(this.texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
