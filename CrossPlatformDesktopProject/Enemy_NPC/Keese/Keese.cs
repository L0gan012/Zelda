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
    public class Keese : IEnemy
    {
        //Instance variables
        private ISprite sprite;
        private Vector2 postion;
        public Keese()
        {
            this.sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyKeese();
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
