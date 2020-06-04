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
    public class ItemMagicShield : IItem
    {
        //Instance variables
        private ISprite sprite;


        public ItemMagicShield()
        {
            //Load Shield sprite
            sprite = ItemsSpriteFactory.Instance.CreateSpriteMagicShield();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Draw current item
            sprite.Draw(spriteBatch);
        }


        public void Update()
        {
            
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
