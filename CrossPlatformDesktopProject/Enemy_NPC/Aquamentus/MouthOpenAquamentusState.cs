using Microsoft.Xna.Framework.Graphics;
using Sprint2.Enemy_NPC;
using Sprint2.Factory;

namespace Sprint2.Enemy
{
    public class MouthOpenAquamentusState : IAquamentusState
    {
        //Instance Variables 
        private Aquamentus aquamentus;
        private ISprite sprite;


        public MouthOpenAquamentusState(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentusMouthOpen();
        }
        public void Draw(SpriteBatch spritebatch)
        {
            sprite.Draw();
        }

        public void MouthClose()
        {
            aquamentus.state = new MouthClosedAquamentusState(aquamentus);
        }

        public void MouthOpen()
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
            aquamentus.state = new AquamentusProjectileState(aquamentus);
        }
    }
}