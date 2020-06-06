using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;
using Sprint2.Sprite;

namespace Sprint2
{
    class UsingItemLinkUpState : ILinkState
    {
        //Instance variables
        private ILink link;
        private ISprite sprite;

        //Constructor with Link instance parameter
        public UsingItemLinkUpState(ILink link)
        {
            this.link = link;
            sprite = LinkSpriteFactory.Instance.CreateUsingItemUpLinkGreenSprite();
        }

        //Updates the State
        public void Update()
        {
            sprite.Update();
        }

        //Draws the sprite attached to the state
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            sprite.Draw(spriteBatch, color, link.Position);
        }

        //Damage Link
        public void DamageLink(Game1 game)
        {
            game.Link = new DamagedLink(link, game);
        }

        //Use compass item
        public void UseItem(IItem item)
        {
            //Already using an item
        }

        //Idle Link Up
        public void SetLinkIdle()
        {
            link.State = new IdleLinkUpState(link);
        }

        //Moves Link Up
        public void MoveLinkLeft()
        {
            link.State = new MovingLinkLeftState(link);
        }

        //Moves Link right
        public void MoveLinkRight()
        {
            link.State = new MovingLinkRightState(link);
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
            link.State = new AttackingLinkUpState(link);
        }
    }
}
