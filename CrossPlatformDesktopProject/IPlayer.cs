using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    interface IPlayer
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

        //Moves the player left
        void MovePlayerLeft();

        //Moves the player right
        void MovePlayerRight();

        //Moves the player up
        void MovePlayerUp();

        //Moves the player down
        void MovePlayerDown();

        //Player attacks left
        void AttackLeft();

        //Player attacks right
        void AttackRight();

        //Player attacks up
        void AttackUp();

        //Player attacks down
        void AttackDown();
    }
}
