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
    public class Gel : IEnemy
    {
        //Instance variables
        private ISprite sprite;
        private Vector2 postion;
        public Gel()
        {
            this.sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGel();
        }
        public void Draw(SpriteBatch spritebatch)
        {
            sprite.Draw(spritebatch);
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
    }
}
