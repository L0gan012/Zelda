using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    interface IPlayer
    {
        //Updates the player
        void Update();

        //Draws the player
        void Draw(SpriteBatch spriteBatch, Texture2D texture);
    }
}
