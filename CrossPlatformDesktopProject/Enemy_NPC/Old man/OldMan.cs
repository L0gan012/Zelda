using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Enemy
{
    public class OldMan : INPC
    {
        private ISprite sprite;
        private Vector2 location;
        private Color color;

        public OldMan()
        {
            sprite = NPCSpriteFactory.Instance.createNPCOldMan();
            location = Constant.EnemyStartPosition;
            color = new Color();
        }

        public void Update()
        {
            sprite.Update();
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, color, location);
        }

    }
}
