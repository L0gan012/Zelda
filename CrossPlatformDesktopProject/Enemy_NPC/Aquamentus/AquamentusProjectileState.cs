using Microsoft.Xna.Framework.Graphics;
using Sprint2.Enemy_NPC;
using Sprint2.Factory;

namespace Sprint2.Enemy
{
    public class AquamentusProjectileState : IAquamentusState
    {
        //Instance Variables 
        private Aquamentus aquamentus;
        private ISprite sprite;

        public AquamentusProjectileState(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentusProjectile();
        }
        public void Draw(SpriteBatch spritebatch)
        {
            sprite.Draw(spritebatch);
        }

        public void MouthOpen()
        {

        }

        public void MouthClose()
        {

        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        public void MoveUp()
        {

        }

        public void Update()
        {
            sprite.Update();
        }

        public void UseProjectile()
        {

        }
    }
}