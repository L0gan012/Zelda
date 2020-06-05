using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;

namespace Sprint2.Enemy
{
    public class LeftMovingDodongoState : IDodongoState
    {
        //Instance Variables 
        private Dodongo dodongo;
        private ISprite sprite;
        public LeftMovingDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyDodongoLeft();
        }

        public void Update()
        {
            sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }

        public void BePuffed()
        {
            dodongo.state = new BePuffedLeftState();
        }

        public void MoveDown()
        {
            dodongo.state = new UpMovingDodongoState(dodongo);
        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {
            dodongo.state = new RightMovingDodongoState(dodongo);
        }

        public void MoveUp()
        {
            dodongo.state = new UpMovingDodongoState(dodongo);
        }

    }
}