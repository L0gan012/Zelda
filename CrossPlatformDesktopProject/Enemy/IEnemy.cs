using Microsoft.Xna.Framework.Graphics;
using System.CodeDom;

namespace Sprint2
{
    public interface IEnemy
    {
        //Updates the Enemy
        void Update();

        //Draws the enemy
        void Draw(SpriteBatch spriteBatch);

        //Enemy walks up
        void MoveUp();

        //Enemy walks down
        void MoveDown();

        //Enemy walks right
        void MoveRight();

        //Enemy walks left
        void MoveLeft();

    }
}
