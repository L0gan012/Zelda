using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IBlock
    {
        //Draws the sprite
        void Draw(SpriteBatch spriteBatch, Vector2 location);


        //Updates the sprite
        void Update();
    }

}
