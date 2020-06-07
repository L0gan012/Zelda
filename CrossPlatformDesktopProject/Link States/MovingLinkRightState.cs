﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;
using Sprint2.Sprite;

namespace Sprint2
{
    class MovingLinkRightState : ILinkState
    {
        //Instance variables
        private ILink link;
        private ISprite sprite;

        //Constructor with Link instance parameter
        public MovingLinkRightState(ILink link)
        {
            this.link = link;
            sprite = LinkSpriteFactory.Instance.CreateMovingRightLinkGreenSprite();
        }

        //Updates the State
        public void Update()
        {
            if (link.Position.X < Constant.ScreenWidth)
            {
                link.Position = new Vector2(link.Position.X + 1, link.Position.Y);
            }
            sprite.Update();
        }

        //Draws the sprite attached to the state
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            sprite.Draw(spriteBatch, color, link.Position);
        }

        //Damage Link
        public void DamageLink(Game1 game) {
            game.Link = new DamagedLink(link, game);
        }

        //Use compass item
        public void UseItem(IItem item)
        {
            item.Use();
            link.State = new UsingItemLinkRightState(link);
        }

        //Idle Link left
        public void SetLinkIdle()
        {
            link.State = new IdleLinkRightState(link);
        }

        //Moves Link left
        public void MoveLinkLeft()
        {
            link.State = new MovingLinkLeftState(link);
        }

        //Moves Link right
        public void MoveLinkRight()
        {
            //Already moving right
        }

        //Moves Link up
        public void MoveLinkUp()
        {
            link.State = new MovingLinkUpState(link);
        }

        //Moves Link down
        public void MoveLinkDown()
        {
            link.State = new MovingLinkDownState(link);
        }

        //Link attacks
        public void Attack()
        {
            link.State = new AttackingLinkRightState(link);
        }
    }
}

