using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    class StationarySprite : ISprite
    {
        //Instance variables
        private int locationX;
        private int locationY;

        //Constructor with game instance parameter
        public StationarySprite(int screenWidth, int screenHeight)
        {
            locationX = screenWidth / 2;
            locationY = screenHeight / 2;
        }

        //Not used update since it is a single image
        public void Update()
        {

        }

        //Draws the sprite to the screen
        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            //Sprite dimensions
            int spriteWidth = 14;
            int spriteHeight = 16;

            //Scale in which the sprite is enlarged by
            int scale = 3;

            //Create source and destination rectangles
            Rectangle sourceRectangle = new Rectangle(58, 4, spriteWidth, spriteHeight);
            Rectangle destinationRectangle = new Rectangle(locationX - spriteWidth*scale/2, locationY - spriteHeight*scale/2, spriteWidth*scale, spriteHeight*scale);

            //Draw specified sprite to the screen
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
