using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface INPC
    {
        //Updates the npc
        void Update();

        //draws the npc
        void Draw(SpriteBatch spritebatch);
    }
}
