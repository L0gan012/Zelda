using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Sprite
{
    public class SpriteLinkAttackWoodenSwordDownGreen : ISprite
    {
        private Texture2D texture;
        //public int Rows { get; set; }
        //public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int currentTick;

        public SpriteLinkAttackWoodenSwordDownGreen(Texture2D texture)
        {

            this.texture = texture;
            currentFrame = 0;
            totalFrames = 5;
            currentTick = 0;
        }


        public void Update()
        {
            if (currentFrame < totalFrames)
            {
                //TODO:(Barry) Testing - Sloppy
                if (currentTick >= Constant.TicksPerFrameAttackSword)
                {
                    currentTick = 0;
                    currentFrame++;
                }
                currentTick++;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Vector2 weaponOffset = new Vector2(5, 16);


            Rectangle sourceRectangleAvatar;
            Rectangle destinationRectangleAvatar;
            Rectangle sourceRectangleWeapon;
            Rectangle destinationRectangleWeapon;
            //Rectangle sourceRectangleProjectile;
            //Rectangle destinationRectangleProjectile;



            if (currentFrame == 0)
            {
                sourceRectangleAvatar = new Rectangle(192, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(192 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 11);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 11 * Constant.DisplayScaleY);



            }
            else if (currentFrame == 1)
            {
                sourceRectangleAvatar = new Rectangle(208, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(208 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 11);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 11 * Constant.DisplayScaleY);
            }
            else if (currentFrame == 2)
            {
                sourceRectangleAvatar = new Rectangle(224, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(224 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 7);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 7 * Constant.DisplayScaleY);
            }
            else if (currentFrame == 3)
            {
                sourceRectangleAvatar = new Rectangle(240, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(224 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 3);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 3 * Constant.DisplayScaleY);

            }
            else
            {
                sourceRectangleAvatar = new Rectangle(0, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(192 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 11);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 11 * Constant.DisplayScaleY);

            }

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangleAvatar, sourceRectangleAvatar, Color.White);
            spriteBatch.Draw(texture, destinationRectangleWeapon, sourceRectangleWeapon, Color.White);
            spriteBatch.End();


        }
    }
}
