using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
   public interface IItem
    {
        //Updates the item
        void Update();

        //Draws the item
        void Draw(SpriteBatch spriteBatch);

        //Uses item
        void Use();
    }
}
