using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics.Eventing.Reader;

namespace Sprint2.Player
{
    public class DamagedLink : ILink
    {
        private static Game1 game;
        private ILink link;

        private int timer;
        private Color color;

        public ILinkState State { get => link.State; set => link.State = value; }
        public IItem Item { get => link.Item; set => link.Item = value; }
        public Vector2 Position { get => link.Position; set => link.Position = value; }

        public DamagedLink(ILink link, Game1 game)
        {
            DamagedLink.game = game;
            this.link = link;

            timer = Constant.DamagedTime;
        }

        public void Update()
        {
            timer--;
            if(timer > 3*Constant.DamagedTime/4)
            {
                color = Color.Blue;
            } else if(timer > 2*Constant.DamagedTime/4)
            {
                color = Color.Red;
            } else if(timer > Constant.DamagedTime/4)
            {
                color = Color.Green;
            } else
            {
                color = Color.Purple;
            }

            if(timer == 0)
            {
                RemoveDecorator();
            }
            link.State.Update();
        }

        public void RemoveDecorator()
        {
            color = Color.White;
            game.Link = link;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            link.State.Draw(spriteBatch, color);
        }

        public void DamagePlayer()
        {
            //Doesn't take damage
        }

        public void UseItem()
        {
            link.State.UseItem(link.Item);
        }

        public void SetIdle()
        {
            link.State.SetLinkIdle();
        }

        public void MoveLeft()
        {
            link.State.MoveLinkLeft();
        }

        public void MoveRight()
        {
            link.State.MoveLinkRight();
        }

        public void MoveUp()
        {
            link.State.MoveLinkUp();
        }

        public void MoveDown()
        {
            link.State.MoveLinkDown();
        }

        public void Attack()
        {
            link.State.Attack();
        }
    }
}