using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    interface IBlock
    {
        //Draws the sprite
        void Draw(SpriteBatch spriteBatch, Texture2D texture);


        //Updates the sprite
        void Update();
    }

}
