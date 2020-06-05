using Microsoft.Xna.Framework.Graphics;
using System.CodeDom;

namespace Sprint2
{
    public interface IEnemy : INPC
    {
        

        //Enemy walks up
        void MoveUp();

        //Enemy walks down
        void MoveDown();

        //Enemy walks right
        void MoveRight();

        //Enemy walks left
        void MoveLeft();

        //eventually add a damage method

    }
}
