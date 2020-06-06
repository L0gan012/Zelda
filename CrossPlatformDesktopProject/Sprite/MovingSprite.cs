using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    class MovingSprite : ISprite
    {
        //Instance variables
        private int locationX;
        private int locationY;
        private readonly int screenHeight;
        private Texture2D texture;

        //Constructor with game instance parameter
        public MovingSprite(int screenWidth, int screenHeight, Texture2D texture)
        {
            locationX = screenWidth/2;
            locationY = 0;
            this.screenHeight = screenHeight;
            this.texture = texture;
        }

        //Update the destination position of the sprite
        public void Update()
        {
            if(locationY >= this.screenHeight)
            {
                locationY = 0;
            }
            else
            {
                locationY += 2;
            }
        }

        //Draws the sprite to the screen
        public void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
        {
            //Dimensions for the sprite
            int spriteWidth = 14;
            int spriteHeight = 16;

            //Scale in which the sprite is enlarged by
            int scale = 3;

            //Source and destination rectangles
            Rectangle sourceRectangle = new Rectangle(58, 4, spriteWidth, spriteHeight);
            Rectangle destinationRectangle = new Rectangle(locationX - spriteWidth*scale/2, locationY, spriteWidth * scale, spriteHeight * scale);

            //Draws the specified sprite to the screen
            spriteBatch.Begin();
            spriteBatch.Draw(this.texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
