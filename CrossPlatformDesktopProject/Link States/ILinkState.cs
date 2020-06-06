﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILinkState
    {
        //Updates the State
        void Update();

        //Draws the sprite attached to the state
        void Draw(SpriteBatch spriteBatch, Color color);

        //Damage Link
        void DamageLink(Game1 game);

        //Use compass item
        void UseItem(IItem item);

        //Idle Link
        void SetLinkIdle();

        //Moves Link left
        void MoveLinkLeft();

        //Moves Link right
        void MoveLinkRight();

        //Moves Link up
        void MoveLinkUp();

        //Moves Link down
        void MoveLinkDown();

        //Link attacks
        void Attack();
    }
}
