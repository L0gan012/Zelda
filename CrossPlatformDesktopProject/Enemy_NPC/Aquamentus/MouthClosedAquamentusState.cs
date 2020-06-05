using Microsoft.Xna.Framework.Graphics;
using Sprint2.Enemy_NPC;
using Sprint2.Factory;

namespace Sprint2.Enemy
{
    public class MouthClosedAquamentusState : IAquamentusState
    {

        //Instance Variables 
        private Aquamentus aquamentus;
        private ISprite sprite;


        public MouthClosedAquamentusState(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentus();
        }

        public void Draw(SpriteBatch spritebatch)
        {
            sprite.Draw(spritebatch);
        }

        public void MouthClose()
        {

        }

        public void MouthOpen()
        {
            aquamentus.state = new MouthOpenAquamentusState(aquamentus);     
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