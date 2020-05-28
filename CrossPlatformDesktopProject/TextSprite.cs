using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    class TextSprite : ISprite
    {
        //Instance variables
        SpriteFont spriteFont;

        private string text;

        private int locationX;
        private int locationY;

        //Constructor with game instance parameter
        public TextSprite(int xLocation, int yLocation, SpriteFont spriteFont, string text)
        {
            this.spriteFont = spriteFont;

            this.text = text;

            locationX = xLocation;
            locationY = yLocation;
        }

        //Empty update since text doesn't change
        public void Update()
        {

        }

        //Draws the text to the screen
        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(spriteFont, text, new Vector2(locationX, locationY), Color.Black);
            spriteBatch.End();
        }
    }
}
