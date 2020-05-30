using Sprint2.LinkState;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Player

{
   class Link : IPlayer
    {
        //Instance variables
        private ILinkState state;
        private static int xPos;
        private static int yPos;

        //Properties
        public ILinkState State
        {
            get { return state; }
            set { state = value; }
        }

        //No parameter constructor, initializes Link to the down idle state
        public Link()
        {
            state = new IdleLinkDown(this);
            //Can change starting position later
            xPos = 0;
            yPos = 0;
        }

        //Updates the player
        void Update()
        {
            state.Update();
        }

        //Draws the player
        void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            state.Draw(spriteBatch, texture, xPos, yPos);
        }

        //Damage player
        void DamagePlayer();

        //Use item
        void UseItem();

        //Sets link to the left idle state
        void IdlePlayerLeft()
        {
            state.IdleLinkLeft(this);
        }

        //Sets link to the right idle state
        void IdlePlayerRight()
        {
            state.IdleLinkRight(this);
        }

        //Sets link to the up idle state
        void IdlePlayerUp()
        {
            state.IdleLinkUp(this);
        }

        //Sets link to the down idle state
        void IdlePlayerDown()
        {
            state.IdleLinkDown(this);
        }

        //Sets link to the moving left state
        void MovePlayerLeft()
        {
            state.MoveLinkLeft(this);
        }

        //Sets link to the moving right state
        void MovePlayerRight()
        {
            state.MoveLinkRight(this);
        }

        //Sets link to the moving up state
        void MovePlayerUp()
        {
            state.MoveLinkUp(this);
        }

        //Sets link to the moving down state
        void MovePlayerDown()
        {
            state.MoveLinkDown(this);
        }

        //Player attacks left
        void AttackLeft();

        //Player attacks right
        void AttackRight();

        //Player attacks up
        void AttackUp();

        //Player attacks down
        void AttackDown();

        //Moves Link left
        void MoveLeft()
        {
            if (xPos > 0)
            {
                xPos--;
            }
        }

        //Moves Link right
        void MoveRight()
        {
            if (xPos < screenWidth)
            {
                xPos++;
            }
        }

        //Moves Link up
        void MoveUp()
        {
            if (yPos > 0)
            {
                yPos--;
            }
        }

        //Moves Link down
        void MoveDown()
        {
            if (yPos < screenHeight)
            {
                yPos++;
            }
        }
    }
}
