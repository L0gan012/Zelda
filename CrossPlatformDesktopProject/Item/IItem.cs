using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IItem
    {
        //Updates the item
        void Update();

        //Draws the item
        void Draw(SpriteBatch spriteBatch, Texture2D texture);

        //Uses the item
        void Use();
    }
}
