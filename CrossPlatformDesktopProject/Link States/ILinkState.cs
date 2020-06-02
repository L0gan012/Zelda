using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILinkState
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
