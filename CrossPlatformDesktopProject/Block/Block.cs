using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Block
{
    class Block : IBlock
    {
        private SpriteBatch spriteBatch;
        private Texture2D texture;
        
        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            state.Draw(spriteBatch, texture);
        }

        public void Update()
        {
            state.Update();
        }
    }

    class Statue : Block
    {
        public IBlock Statue
        {

        }
    }
}
