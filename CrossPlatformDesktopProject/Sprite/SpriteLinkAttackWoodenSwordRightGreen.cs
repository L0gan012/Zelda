using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    //TODO:(Barry) Rename texture for different sprite sheets
    private Texture2D texture;
    private Vector2 position;
    private int currentFrame;
    private int totalFrames;
    private int currentTick;
    private Game1 game;
    private Iplayer link;

    public SpriteLinkAttackWoodenSwordDownGreen(Game1 game, Iplayer link)
    {
        this.game = game;
        texture = this.game.texture;
        this.link = link;
        position = this.link.position;


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

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 weaponOffset = new Vector2(16, 5);


            Rectangle sourceRectangleAvatar;
            Rectangle destinationRectangleAvatar;
            Rectangle sourceRectangleWeapon;
            Rectangle destinationRectangleWeapon;
            //Rectangle sourceRectangleProjectile;
            //Rectangle destinationRectangleProjectile;



            //     if (currentFrame == 0)
            //  {
            //       sourceRectangleAvatar = new Rectangle(272, 16, 16, 16);
            //       destinationRectangleAvatar = new Rectangle((int)location.X, (int)location.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

            //       sourceRectangleWeapon = new Rectangle(272 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 11, 8);
            //       destinationRectangleWeapon = new Rectangle((int)location.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)location.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 11 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);

            //    }

            if (currentFrame == 0)
            {
                sourceRectangleAvatar = new Rectangle(304, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(304 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 11, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 11 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else if (currentFrame == 1)
            {
                sourceRectangleAvatar = new Rectangle(336, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(336 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 7, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 7 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else if (currentFrame == 2)
            {
                sourceRectangleAvatar = new Rectangle(368, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(368 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 3, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 3 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);

            }
            else
            {
                sourceRectangleAvatar = new Rectangle(48, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(272 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 11, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 11 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);

            }

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangleAvatar, sourceRectangleAvatar, Color.White);
            spriteBatch.Draw(texture, destinationRectangleWeapon, sourceRectangleWeapon, Color.White);
            spriteBatch.End();


        }
    }
}
