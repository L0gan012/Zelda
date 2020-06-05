using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    public class SpriteLinkUseItemRightGreen : ISprite
    {
        private Texture2D texture;

        public SpriteLinkUseItemRightGreen(Texture2D texture)
        {
            this.texture = texture;
        }


        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            sourceRectangle = new Rectangle(672, 16, 16, 16);
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


