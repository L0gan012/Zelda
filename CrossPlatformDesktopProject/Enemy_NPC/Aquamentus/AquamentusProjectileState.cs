using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Enemy_NPC;
using Sprint2.Factory;

namespace Sprint2
{
    public class AquamentusProjectileStateFired 
    {
        //Instance Variables 
        private Aquamentus aquamentus;
        private ISprite sprite;

        public AquamentusProjectileStateFired(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentusProjectile();
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location)
        {
            sprite.Draw(spritebatch, location);
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