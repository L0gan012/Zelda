using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Enemy_NPC;
using Sprint2.Factory;

namespace Sprint2
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
        public void Draw(SpriteBatch spritebatch, Color color, Vector2 location)
        {
            sprite.Draw(spritebatch, color, location);
        }

        public void MouthClose()
        {
            aquamentus.State = new MouthClosedAquamentusState(aquamentus);
        }

        public void MouthOpen()
        {

        }

        public void Update()
        {
            sprite.Update();
        }

        public void UseProjectile()
        {
            //aquamentus.State = new AquamentusProjectileState(aquamentus);
        }
    }
}