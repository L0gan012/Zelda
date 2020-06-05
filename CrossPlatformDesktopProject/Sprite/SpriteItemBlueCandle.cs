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



            public SpriteItemBlueCandle(Texture2D texture)
            {
                Texture = texture;
                Rows = 1;
                Columns = 1;
                currentFrame = 0;
                currentTick = 0;
                totalFrames = Rows * Columns;
            }


            public void Update()
            {

            }


            public void Draw(SpriteBatch spriteBatch, Vector2 position)
            {
                int width = Texture.Width / Columns;
                int height = Texture.Height / Rows;
                int row = (int)((float)currentFrame / (float)Columns);
                int column = currentFrame % Columns;

                Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
                Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width * Constant.ScaleDisplayX, height * Constant.ScaleDisplayY);

                spriteBatch.Begin();
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
        }
    }

