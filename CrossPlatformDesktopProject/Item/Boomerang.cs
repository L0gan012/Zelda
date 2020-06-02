using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Item
{
    class Boomerang : IItem
    {
        //Instance variables
        private ISprite sprite;
        private ItemsSpriteFactory spriteFactory;

        public Boomerang()
        {
            /*Load new Block sprite
            sprite = ItemsFactory.Instance.CreateSpriteBoomerang());*/

        }

        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            /*Todo draw current item
            sprite.Draw(spriteBatch, texture);*/
        }

        public void Update()
        {
            //sprite.Update();
        }
    }
}
