using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics.Eventing.Reader;

namespace Sprint2
{
    public class Link : ILink
    {
        private static Game1 game;
        private static Color color;

        public Vector2 Position { get; set; }
        public ILinkState State { get; set; }
        public IItem Item { get; set; }

        public Link(Game1 game)
        {
            Link.game = game;
            Position = Constant.LinkStartPosition;

            State = new IdleLinkDownState(this);
            color = Color.White;
        }

        public void Update()
        {
            State.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch, color);
        }

        public void DamagePlayer() 
        {
            State.DamageLink(game);
        }

        public void UseItem() 
        {
            State.UseItem(Item);
        }

        public void SetIdle()
        {
            State.SetLinkIdle();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void MoveLeft()
        {
            State.MoveLinkLeft();
        }

        public void MoveRight()
        {
            State.MoveLinkRight();
        }

        public void MoveUp()
        {
            State.MoveLinkUp();
        }

        public void MoveDown()
        {
            State.MoveLinkDown();
        }
    }
}