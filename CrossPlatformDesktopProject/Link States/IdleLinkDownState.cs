using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;
using Sprint2.Sprite;

namespace Sprint2
{
    class IdleLinkDownState : ILinkState
    {
        //Instance variables
        private IPlayer link;
        private ISprite sprite;
        private LinkSpriteFactory spriteFactory;

        //Constructor with Link instance parameter
        public IdleLinkDownState(Link link, Vector2 position)
        {
            this.link = link;
            spriteFactory = LinkSpriteFactory.Instance;
            sprite = new SpriteLinkIdleDownGreen(position);
        }

        //Updates the State
        public void Update(){
            sprite.Update();
        }

        //Draws the sprite attached to the state
        public void Draw(SpriteBatch spriteBatch, Texture2D texture){
            sprite.Draw(spriteBatch, texture);
        }

        //Damage Link
        public void DamageLink(){}

        //Use compass item
        public void UseCompass(){}

        //Use map item
        public void UseMap(){}

        //Use key item
        public void UseKey(){}

        //Use heart container item
        public void UseHeartContainer(){}

        //Use triforce piece item
        public void UseTriforcePiece(){}

        //Use wooden boomerang item
        public void UseWoodenBoomerang(){}

        //Use bow item
        public void UseBow(){}

        //Use heart item
        public void UseHeart(){}

        //Use rupee item
        public void UseRupee(){}

        //Use arrow item
        public void UseArrow(){}

        //Use bomb item
        public void UseBomb(){}

        //Use fairy item
        public void UseFairy(){}

        //Use clock item
        public void UseClock(){}

        //Idle Link left
        public void SetLinkIdle(){
            //NO-OP
            //Already idle
        }

        //Moves Link left
        public void MoveLinkLeft(){
            sprite = spriteFactory.CreateMovingLeftLinkSprite();
        }

        //Moves Link right
        public void MoveLinkRight(){
            sprite = spriteFactory.CreateMovingRightLinkSprite();
        }

        //Moves Link up
        public void MoveLinkUp(){
            sprite = spriteFactory.CreateMovingUpLinkSprite();
        }

        //Moves Link down
        public void MoveLinkDown(){
            sprite = spriteFactory.CreateMovingDownLinkSprite();
        }

        //Link attacks
        public void Attack() {
            sprite = spriteFactory.CreateAttackingDownLinkSprite();
        }
    }
}
