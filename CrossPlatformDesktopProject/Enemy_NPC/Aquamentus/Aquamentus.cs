using Microsoft.Xna.Framework.Graphics;
using Sprint2.Enemy_NPC;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Aquamentus : IEnemy
    {

        //Instance variables
        public IAquamentusState State { get; set; }
        private ISprite projectile;
        private Vector2 location;
        private bool left;
        private float limit;
        private Color color;
       

        public Aquamentus()
        {
            State = new MouthClosedAquamentusState(this);
            location = Constant.EnemyStartPosition;
            color = Color.White;
           // projectile = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentusProjectile();

            //movement 
            left = true;
            limit = location.X - Constant.RNG.Next(Constant.AquamentusXRange);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch, color, location);
           // projectile.Draw(spriteBatch, color, location);

        }

        public void takeDamage()
        {
            //nothing yet
        }

        

        public void Update()
        {
            //TODO - take care of random movement and projectiles
            if(left)
            {
                location.X--;
                if(Convert.ToInt32(location.X) < limit)
                {
                    left = false;
                    limit = location.X + Constant.RNG.Next(Constant.AquamentusXRange);
                }

            } else
            {
                location.X++;
                if (Convert.ToInt32(location.X) > limit)
                {
                    left = true;
                    limit = location.X - Constant.RNG.Next(Constant.AquamentusXRange);
                }
            }
            
            State.Update();
        }


    }
}
