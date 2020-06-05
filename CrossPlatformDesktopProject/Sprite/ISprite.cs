using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace Sprint2
{
    //Sprite Interface
    public interface ISprite
    {
        //Updates the sprite
        void Update();

        //Draws the sprite
        void Draw(SpriteBatch spriteBatch, Vector2 position);
    }
}
