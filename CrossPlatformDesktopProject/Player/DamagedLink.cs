using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics.Eventing.Reader;

namespace Sprint2.Player
{
    public class DamagedLink : ILink
    {
        //Instance variables
        private static Game1 game;
        private ILink link;
        private ILinkState state;
        private IItem item;
        private Vector2 position;
        private int timer;

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
        public DamagedLink(ILink link, Game1 game)
        {
            DamagedLink.game = game;
            this.link = link;
            state = link.State;
            item = link.Item;
            position = link.Position;
            timer = Constant.DamagedTime;
        }

        //Updates the player
        public void Update()
        {
            timer--;
            if(timer == 0)
            {
                RemoveDecorator();
            }
            link.Update();
        }

        //Removes the decorator
        public void RemoveDecorator()
        {
            game.Link = link;
        }

        //Draws the player
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }

        //Damage Link
        public void DamagePlayer()
        {
            //Doesn't take damage
        }

        //Use item
        public void UseItem()
        {
            state.UseItem(item);
        }

        //Sets link to the idle state
        public void SetIdle()
        {
            state.SetLinkIdle();
            state.SetDamagedSprite();
        }

        //Sets link to the moving left state
        public void MovePlayerLeft()
        {
            state.MoveLinkLeft();
            state.SetDamagedSprite();
        }

        //Sets link to the moving right state
        public void MovePlayerRight()
        {
            state.MoveLinkRight();
            state.SetDamagedSprite();
        }

        //Sets link to the moving up state
        public void MovePlayerUp()
        {
            state.MoveLinkUp();
            state.SetDamagedSprite();
        }

        //Sets link to the moving down state
        public void MovePlayerDown()
        {
            state.MoveLinkDown();
            state.SetDamagedSprite();
        }

        //Player attacks
        public void Attack()
        {
            state.Attack();
            state.SetDamagedSprite();
        }

        //Moves Link left
        public void MoveLeft()
        {
            if (position.X > 0)
            {
                position.X--;
            }
        }

        //Moves Link right
        public void MoveRight()
        {
            if (position.X < Constant.ScreenWidth)
            {
                position.X += 1;
            }
        }

        //Moves Link up
        public void MoveUp()
        {
            if (position.Y > 0)
            {
                position.Y--;
            }
        }

        //Moves Link down
        public void MoveDown()
        {
            if (position.Y < Constant.ScreenHeight)
            {
                position.Y++;
            }
        }
    }
}