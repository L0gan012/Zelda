using Microsoft.Xna.Framework.Graphics;


namespace Sprint2.Block
{
    class Block : IBlock
    {
        private IBlock state;
        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            state.Draw(spriteBatch, texture);
        }

        public void Update()
        {
            state.Update();
        }
    }
}
