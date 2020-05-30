using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    interface ILinkState
    {
        //Updates the State
        void Update();

        //Draws the sprite attached to the state
        void Draw(SpriteBatch spriteBatch, Texture2D texture);

        //Damage Link
        void DamageLink();

        //Use compass item
        void UseCompass();

        //Use map item
        void UseMap();

        //Use key item
        void UseKey();

        //Use heart container item
        void UseHeartContainer();

        //Use triforce piece item
        void UseTriforcePiece();

        //Use wooden boomerang item
        void UseWoodenBoomerang();

        //Use bow item
        void UseBow();

        //Use heart item
        void UseHeart();

        //Use rupee item
        void UseRupee();

        //Use arrow item
        void UseArrow();

        //Use bomb item
        void UseBomb();

        //Use fairy item
        void UseFairy();

        //Use clock item
        void UseClock();

        //Idle Link left
        void IdleLinkLeft();

        //Idle Link right
        void IdleLinkRight();

        //Idle Link up
        void IdleLinkUp();

        //Idle Link down
        void IdleLinkDown();

        //Moves Link left
        void MoveLinkLeft();

        //Moves Link right
        void MoveLinkRight();

        //Moves Link up
        void MoveLinkUp();

        //Moves Link down
        void MoveLinkDown();

        //Link attacks with wood sword left
        void AttackWoodSwordLeft();

        //Link attacks with wood sword right
        void AttackWoodSwordRight();

        //Link attacks with wood sword up
        void AttackWoodSwordUp();

        //Link attacks with wood sword down
        void AttackWoodSwordDown();

        //Link attacks with white sword left
        void AttackWhiteSwordLeft();

        //Link attacks with white sword right
        void AttackWhiteSwordRight();

        //Link attacks with white sword up
        void AttackWhiteSwordUp();

        //Link attacks with white sword down
        void AttackWhiteSwordDown();

        //Link attacks with magic sword left
        void AttackMagicSwordLeft();

        //Link attacks with magic sword right
        void AttackMagicSwordRight();

        //Link attacks with magic sword up
        void AttackMagicSwordUp();

        //Link attacks with magic sword down
        void AttackMagicSwordDown();

        //Link attacks with magic rod left
        void AttackMagicRodLeft();

        //Link attacks with magic rod right
        void AttackMagicRodRight();

        //Link attacks with magic rod up
        void AttackMagicRodUp();

        //Link attacks with magic rod down
        void AttackMagicRodDown();
    }
}
