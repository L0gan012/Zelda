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
    public class ItemWoodenArrow : IItem
    {
        //Instance variables
        private ISprite sprite;
 

        public ItemWoodenArrow()
        {
            //Load wooden arrow sprite
            sprite = ItemsSpriteFactory.Instance.CreateSpriteWoodenArrow();
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
