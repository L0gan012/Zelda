using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Player
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


        //Sets the player left state
        void MovePlayerLeft();

        //Sets the player right state
        void MovePlayerRight();

        //Sets the player up state
        void MovePlayerUp();

        //Sets the player down state
        void MovePlayerDown();

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
