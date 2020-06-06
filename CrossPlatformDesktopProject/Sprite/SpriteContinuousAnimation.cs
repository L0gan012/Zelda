﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;



namespace Sprint2.Sprite
{
    class SpriteContinuousAnimation : ISprite
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int ticksPerFrame;
        private int currentTick;


        public SpriteContinuousAnimation(Texture2D texture, int row, int column, int ticksPerFrame)
        {
            Texture = texture;
            Rows = row;
            Columns = column;
            currentFrame = 0;
            totalFrames = Rows * Columns;
            this.ticksPerFrame = ticksPerFrame;

        }

        public void Draw(SpriteBatch spriteBatch, Color color, Vector2 location)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * Constant.DisplayScaleX, height * Constant.DisplayScaleY);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, color);
            spriteBatch.End();
        }

        public void Update()
        {
            if (currentTick >= ticksPerFrame)
            {
                currentTick = 0;
                currentFrame++;
                if (currentFrame >= totalFrames)
                    currentFrame = 0;
            }
            currentTick++;
        }
    }

}
