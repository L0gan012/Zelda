using Microsoft.Xna.Framework.Graphics;
using Sprint2.Player;
using Sprint2.Sprite;

namespace Sprint2
{
    class IdleLinkDownState : ILinkState
    {
        //Instance variables
        private IPlayer link;
        private ISprite sprite;

        //Constructor with Link instance parameter
        public IdleLinkDownState(Link link, float xPos, float yPos)
        {
            this.link = link;
            sprite = new SpriteLinkIdleDownGreen(xPos, yPos);
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
        public void IdleLinkLeft(){}

        //Idle Link right
        public void IdleLinkRight(){}

        //Idle Link up
        public void IdleLinkUp(){}

        //Idle Link down
        public void IdleLinkDown(){}

        //Moves Link left
        public void MoveLinkLeft(){}

        //Moves Link right
        public void MoveLinkRight(){}

        //Moves Link up
        public void MoveLinkUp(){}

        //Moves Link down
        public void MoveLinkDown(){}

        //Link attacks with wood sword left
        public void AttackWoodSwordLeft(){}

        //Link attacks with wood sword right
        public void AttackWoodSwordRight(){}

        //Link attacks with wood sword up
        public void AttackWoodSwordUp(){}

        //Link attacks with wood sword down
        public void AttackWoodSwordDown(){}

        //Link attacks with white sword left
        public void AttackWhiteSwordLeft(){}

        //Link attacks with white sword right
        public void AttackWhiteSwordRight(){}

        //Link attacks with white sword up
        public void AttackWhiteSwordUp(){}

        //Link attacks with white sword down
        public void AttackWhiteSwordDown(){}

        //Link attacks with magic sword left
        public void AttackMagicSwordLeft(){}

        //Link attacks with magic sword right
        public void AttackMagicSwordRight(){}

        //Link attacks with magic sword up
        public void AttackMagicSwordUp(){}

        //Link attacks with magic sword down
        public void AttackMagicSwordDown(){}

        //Link attacks with magic rod left
        public void AttackMagicRodLeft(){}

        //Link attacks with magic rod right
        public void AttackMagicRodRight(){}

        //Link attacks with magic rod up
        public void AttackMagicRodUp(){}

        //Link attacks with magic rod down
        public void AttackMagicRodDown(){}
    }
}
