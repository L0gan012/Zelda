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
    public class ItemBluePotion : IItem
    {
        //Instance variables
        private ISprite sprite;
        private Vector2 location;
        private Color color;

        public ItemBluePotion()
        {
            //Load Blue Potion sprite
            sprite = ItemsSpriteFactory.Instance.CreateSpriteBluePotion();
            location = Constant.ItemStartPosition;
            color = new Color();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Draw current item
            sprite.Draw(spriteBatch, color, location);
        }


        public void Update()
        {
            sprite.Update();
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
