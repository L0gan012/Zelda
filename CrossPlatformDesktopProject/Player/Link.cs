using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics.Eventing.Reader;

namespace Sprint2
{
    public class Link : ILink
    {
        //Instance variables
        private static Game1 game;
        private static ILinkState state;
        private IItem item;
        private static Vector2 position;
        private static Color color;

        //Properties
        public ILinkState State
        {
            get { return state; }
            set { state = value; }
        }

        public IItem Item
        {
            get { return item; }
            set { item = value; }
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        //No parameter constructor, initializes Link to the down idle state
        public Link(Game1 game)
        {
            //Can change starting position later
            Link.game = game;
            position = Constant.LinkStartPosition;

            state = new IdleLinkDownState(this);
            color = Color.White;
        }

        //Updates the player
        public void Update()
        {
            state.Update();
        }

        //Draws the player
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch, color);
        }

        //Damage Link
        public void DamagePlayer() {
            state.DamageLink(game);
        }

        //Use item
        public void UseItem() {
            state.UseItem(item);
        }

        //Sets link to the idle state
        public void SetIdle()
        {
            state.SetLinkIdle();
        }

       
        //Player attacks
        public void Attack() {
            state.Attack();
        }

        //Moves Link left
        public void MoveLeft()
        {
            state.MoveLinkLeft();

            while (position.X > 0)
            {
                position.X--;
            }
        }

        //Moves Link right
        public void MoveRight()
        {
            state.MoveLinkRight();

            while (position.X < Constant.ScreenWidth)
            {
                position.X++;
            }
        }

        //Moves Link up
        public void MoveUp()
        {
            state.MoveLinkUp();

            while (position.Y > 0)
            {
                position.Y--;
            }
        }

        //Moves Link down
        public void MoveDown()
        {
            state.MoveLinkDown();

            while (position.Y < Constant.ScreenHeight)
            {
                position.Y++;
            }
        }
    }
}