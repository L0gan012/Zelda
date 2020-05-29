using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    interface IItem
    {
        //Updates the item
        void Update();

        //Draws the item
        void Draw(SpriteBatch spriteBatch, Texture2D texture);
    }
}
