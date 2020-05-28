using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    //Sprite Interface
    public interface ISprite
    {
        //Updates the sprite
        void Update();

        //Draws the sprite
        void Draw(SpriteBatch spriteBatch, Texture2D texture);
    }
}
