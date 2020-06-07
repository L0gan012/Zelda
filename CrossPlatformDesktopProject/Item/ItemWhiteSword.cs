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
    public class ItemWhiteSword : IItem
    {
        //Instance variables
        private ISprite sprite;
        private Color color;
        private Vector2 location;

        public ItemWhiteSword()
        {
            //Load White Sword sprite
            sprite = ItemsSpriteFactory.Instance.CreateSpriteWhiteSword();
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
            
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
