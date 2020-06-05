using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface INPC
    {
        //Updates the npc
        public void Update();

        //draws the npc
        public void Draw(SpriteBatch spritebatch);
    }
}
