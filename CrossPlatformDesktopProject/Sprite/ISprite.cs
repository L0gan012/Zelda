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
        void Draw(SpriteBatch spriteBatch, Color color, Vector2 position);
        void Draw(SpriteBatch spriteBatch, Color color, object location);
    }
}
