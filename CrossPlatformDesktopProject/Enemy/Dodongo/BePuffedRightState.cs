using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;

namespace Sprint2.Enemy
{
    public class BePuffedRightState : IDodongoState
    {

        //Instance Variables 
        private Dodongo dodongo;
        private ISprite sprite;

        public BePuffedRightState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyDodongoRightPuffed();
        }
        public void BePuffed()
        {

        }

        public void Update()
        {
            sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }


        public void MoveDown()
        {
            dodongo.state = new DownMovingDodongoState(dodongo);
        }

        public void MoveLeft()
        {
            dodongo.state = new LeftMovingDodongoState(dodongo);
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