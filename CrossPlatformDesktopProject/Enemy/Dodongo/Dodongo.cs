using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Enemy
{
    public class Dodongo : IEnemy
    {

        //Instance variables
        public IDodongoState state;

        public Dodongo()
        {
            state = new RightMovingDodongoState(this);
        }

        public void Update()
        {
            state.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }

        public void BePuffed()
        {
            state.BePuffed();
        }

        public void MoveDown()
        {
            state.MoveDown();
        }

        public void MoveLeft()
        {
            state.MoveLeft();
        }

        public void MoveRight()
        {
            state.MoveRight();
        }

        public void MoveUp()
        {
            state.MoveUp();
        }
    }
}
