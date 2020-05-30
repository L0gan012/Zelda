using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IPlayer
    {
        //Updates the player
        void Update();

        //Draws the player
        void Draw(SpriteBatch spriteBatch, Texture2D texture);

        //Damage player
        void DamagePlayer();

        //Use item
        void UseItem();

        //Idle left
        void IdlePlayerLeft();

        //Idle right
        void IdlePlayerRight();

        //Idle up
        void IdlePlayerUp();

        //Idle down
        void IdlePlayerDown();

        //Sets the player left state
        void MovePlayerLeft();

        //Sets the player right state
        void MovePlayerRight();

        //Sets the player up state
        void MovePlayerUp();

        //Sets the player down state
        void MovePlayerDown();

        //Player attacks left
        void AttackLeft();

        //Player attacks right
        void AttackRight();

        //Player attacks up
        void AttackUp();

        //Player attacks down
        void AttackDown();

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
