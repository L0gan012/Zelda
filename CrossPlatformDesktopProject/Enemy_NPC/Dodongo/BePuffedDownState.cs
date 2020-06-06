using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;

namespace Sprint2.Enemy
{
    public class BePuffedDownState : IDodongoState
    {

        //Instance Variables 
        private Dodongo dodongo;
        private ISprite sprite;
        private Vector2 location;

        public BePuffedDownState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyDodongoLeftPuffed();
            location = Constant.EnemyStartPosition;
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
            sprite.Draw(spriteBatch, location);
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

        public void takeDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}