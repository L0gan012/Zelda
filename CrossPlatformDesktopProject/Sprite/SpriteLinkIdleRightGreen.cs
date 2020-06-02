using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteLinkIdleRightGreen
    {
        public Texture2D texture;
        public Vector2 location;

        public StillFixedSprite(Texture2D texture)
        {
            this.texture = texture;

            //TODO: (Barry)  Get location of Link
            location = Constant.LinkStartPosition;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            sourceRectangle = new Rectangle(0, 48, 16, 16);
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }


        public void Update()
        {

        }
    }
}