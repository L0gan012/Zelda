using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq.Expressions;

namespace Sprint2
{
    public class SpriteItemBlueCandle : ISprite
    {
            public Texture2D Texture { get; set; }
            public int Rows { get; set; }
            public int Columns { get; set; }
            private int currentTick;
            private int currentFrame;
            private int totalFrames;



            public SpriteItemBlueCandle(Texture2D texture, int rows, int columns)
            {
                Texture = texture;
                Rows = rows;
                Columns = columns;
                currentFrame = 0;
                currentTick = 0;
                totalFrames = Rows * Columns;
            }


            public void Update()
            {
                if (currentTick >= 8)
                {
                    currentTick = 0;
                    currentFrame++;
                    if (currentFrame >= totalFrames)
                        currentFrame = 0;
                }
                currentTick++;
            }


            public void Draw(SpriteBatch spriteBatch, Vector2 location)
            {
                int width = Texture.Width / Columns;
                int height = Texture.Height / Rows;
                int row = (int)((float)currentFrame / (float)Columns);
                int column = currentFrame % Columns;

                Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * Constant.ScaleDisplayX, height * Constant.ScaleDisplayY);

                spriteBatch.Begin();
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
        }
    }

