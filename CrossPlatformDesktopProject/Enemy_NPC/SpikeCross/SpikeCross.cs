using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Enemy_NPC
{
    public class SpikeCross : IEnemy
    {
        //Instance variables
        private ISprite sprite;
        private Vector2 location;
        private Color color;
        public SpikeCross()
        {
            this.sprite = EnemySpriteFactory.Instance.CreateSpriteEnemySpikeCross();
            location = Constant.EnemyStartPosition;
            color = Color.White;

        }
        public void Draw(SpriteBatch spritebatch)
        {
            sprite.Draw(spritebatch, color, location);
        }

        public void takeDamage()
        {
        }

        public void Update()
        {
            sprite.Update();
        }
    }
}
