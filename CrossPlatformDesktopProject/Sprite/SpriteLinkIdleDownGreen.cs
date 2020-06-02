using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteLinkIdleDownGreen : ISprite
    {
         private Texture2D texture;
        private Vector2 position;

        public SpriteLinkIdleDownGreen(Texture2D texture)
        {
            this.texture = texture;

            //TODO: (Barry)  Get location of Link
            position = Constant.LinkStartPosition;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            sourceRectangle = new Rectangle(0, 16, 16, 16);
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


