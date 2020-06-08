﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Sprite
{
    public class SpriteLinkAttackWoodenSwordRightGreen : ISprite
    {
        private Texture2D texture;
        private int currentFrame;
        private int totalFrames;
        private int currentTick;


        public SpriteLinkAttackWoodenSwordRightGreen(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
            totalFrames = 4;
            currentTick = 0;
        }


        public void Update()
        {
            if (currentFrame < totalFrames)
            {
                if (currentTick >= Constant.TicksPerFrameAttackSword)
                {
                    currentTick = 0;
                    currentFrame++;
                }
                currentTick++;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
        {
            Vector2 weaponOffset = new Vector2(16, 5);


            Rectangle sourceRectangleAvatar;
            Rectangle destinationRectangleAvatar;
            Rectangle sourceRectangleWeapon;
            Rectangle destinationRectangleWeapon;
            //Rectangle sourceRectangleProjectile;
            //Rectangle destinationRectangleProjectile;



            if (currentFrame == 0)
            {
                   sourceRectangleAvatar = new Rectangle(272, 16, 16, 16);
                   destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                   sourceRectangleWeapon = new Rectangle(272 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 16, 8);
                   destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 16 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);

            }

            else if (currentFrame == 1)
            {
                sourceRectangleAvatar = new Rectangle(304, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(304 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 11, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 11 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else if (currentFrame == 2)
            {
                sourceRectangleAvatar = new Rectangle(336, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(336 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 7, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 7 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else
            {
                sourceRectangleAvatar = new Rectangle(368, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(368 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 3, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 3 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);

            }


            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangleAvatar, sourceRectangleAvatar, color);
            spriteBatch.Draw(texture, destinationRectangleWeapon, sourceRectangleWeapon, color);
            spriteBatch.End();


        }
    }
    
}
