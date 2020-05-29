using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    interface IState
    {
        //Updates the State
        void Update();

        //Draws the sprite attached to the state
        void Draw(SpriteBatch spriteBatch, Texture2D texture);
    }
}
