using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    class StationarySprite : ISprite
    {
        //Instance variables
        private int locationX;
        private int locationY;
        private Texture2D texture;

        //Constructor with game instance parameter
        public StationarySprite(int screenWidth, int screenHeight, Texture2D texture)
        {
            locationX = screenWidth / 2;
            locationY = screenHeight / 2;
            this.texture = texture;
        }

        //Not used update since it is a single image
        public void Update()
        {

        }

        //Draws the sprite to the screen
        public void Draw(SpriteBatch spriteBatch, Vector2 position)
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
            spriteBatch.Draw(this.texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
