using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILink
    {
        ILinkState State { get; set; }

        IItem Item { get; set; }

        Vector2 Position { get; set; }

        //Updates the player
        void Update();

        //Draws the player
        void Draw(SpriteBatch spriteBatch);

        //Damage player
        void DamagePlayer();

        //Use item
        void UseItem();

        //Idle
        void SetIdle();

        //Player attacks
        void Attack();

        //Moves the player left
        void MoveLeft();

        //Moves the player right
        void MoveRight();

        //Moves the player up
        void MoveUp();

        //Moves the player down
        void MoveDown();
    }
}
