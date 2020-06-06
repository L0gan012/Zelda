using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Enemy.Oldman
{
    public class OldMan : INPC
    {
        private ISprite sprite;
        private Vector2 location;

        public OldMan()
        {
            sprite = NPCSpriteFactory.Instance.createNPCOldMan();
        }

        public void Update()
        {
            sprite.Update();
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, location);
        }

    }
}
