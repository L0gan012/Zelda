using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics.Eventing.Reader;

namespace Sprint2.Player
{
    public class DamagedLink : IPlayer
    {
        //Instance variables
        private static Game1 game;
        private Link link;
        private int timer;

        //No parameter constructor, initializes Link to the down idle state
        public DamagedLink(Link link, Game1 game)
        {
            DamagedLink.game = game;
            this.link = link;
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
        }

        //Sets link to the moving left state
        public void MovePlayerLeft()
        {
            state.MoveLinkLeft();
        }

        //Sets link to the moving right state
        public void MovePlayerRight()
        {
            state.MoveLinkRight();
        }

        //Sets link to the moving up state
        public void MovePlayerUp()
        {
            state.MoveLinkUp();
        }

        //Sets link to the moving down state
        public void MovePlayerDown()
        {
            state.MoveLinkDown();
        }

        //Player attacks
        public void Attack()
        {
            state.Attack();
        }

        //Moves Link left
        public void MoveLeft()
        {
            if (link.Position.X > 0)
            {
                link.Position.X--;
            }
        }

        //Moves Link right
        public void MoveRight()
        {
            if (link.Position.X < Constant.ScreenWidth)
            {
                link.Position.X += 1;
            }
        }

        //Moves Link up
        public void MoveUp()
        {
            if (link.Position.Y > 0)
            {
                link.Position.Y--;
            }
        }

        //Moves Link down
        public void MoveDown()
        {
            if (link.Position.Y < Constant.ScreenHeight)
            {
                link.Position.Y++;
            }
        }
    }
}