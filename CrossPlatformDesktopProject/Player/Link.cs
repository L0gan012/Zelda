using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Player
{
    class Link : IPlayer
    {
        //Instance variables
        private ILinkState state;

        private IItem item;

        private static float xPos;
        private static float yPos;

        //Properties
        public ILinkState State
        {
            get { return state; }
            set { state = value; }
        }

        //No parameter constructor, initializes Link to the down idle state
        public Link()
        {
            state = new IdleLinkDownState(this, xPos, yPos);

            //Can change starting position later
            xPos = Constant.LinkStartPosition.X;
            yPos = Constant.LinkStartPosition.Y;
        }

        //Updates the player
        public void Update()
        {
            state.Update();
        }

        //Draws the player
        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            state.Draw(spriteBatch, texture);
        }

        //Damage Link
        public void DamagePlayer() {
            state.DamageLink(xPos, yPos, item);
        }

        //Use item
        public void UseItem() { }

        //Sets link to the left idle state
        public void IdlePlayerLeft()
        {
            state.IdleLinkLeft(this);
        }

        //Sets link to the right idle state
        public void IdlePlayerRight()
        {
            state.IdleLinkRight(this);
        }

        //Sets link to the up idle state
        public void IdlePlayerUp()
        {
            state.IdleLinkUp(this);
        }

        //Sets link to the down idle state
        public void IdlePlayerDown()
        {
            state.IdleLinkDown(this);
        }

        //Sets link to the moving left state
        public void MovePlayerLeft()
        {
            state.MoveLinkLeft(this);
        }

        //Sets link to the moving right state
        public void MovePlayerRight()
        {
            state.MoveLinkRight(this);
        }

        //Sets link to the moving up state
        public void MovePlayerUp()
        {
            state.MoveLinkUp(this);
        }

        //Sets link to the moving down state
        public void MovePlayerDown()
        {
            state.MoveLinkDown(this);
        }

        //Player attacks left
        public void AttackLeft() {
            
        }

        //Player attacks right
        public void AttackRight() { }

        //Player attacks up
        public void AttackUp() { }

        //Player attacks down
        public void AttackDown() { }

        //Moves Link left
        public void MoveLeft()
        {
            if(xPos > 0)
            {
                xPos--;
            }
        }

        //Moves Link right
        public void MoveRight()
        {
            if(xPos < Constant.ScreenWidth)
            {
                xPos++;
            }
        }

        //Moves Link up
        public void MoveUp()
        {
            if(yPos > 0)
            {
                yPos--;
            }
        }

        //Moves Link down
        public void MoveDown()
        {
            if(yPos < Constant.ScreenHeight)
            {
                yPos++;
            }
        }
    }
}