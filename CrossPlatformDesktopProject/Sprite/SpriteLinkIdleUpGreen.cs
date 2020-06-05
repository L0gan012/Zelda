using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteLinkIdleUpGreen : ISprite
    {
         private Texture2D texture;

        public SpriteLinkIdleUpGreen(Texture2D texture)
        {
            this.texture = texture;
        }


        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            sourceRectangle = new Rectangle(144, 16, 16, 16);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }


        public void Update()
        {

        }
    }
}
