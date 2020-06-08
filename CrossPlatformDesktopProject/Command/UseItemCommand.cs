namespace Sprint2.Controller
{
    internal class UseItemCommand : ICommand
    {
        private Game1 game;

        public UseItemCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            //TODO: I assuming this is how this should work. May need to change 
            //this.game.Link.UseItem(this.game.ListOfItems[this.game.ItemListPosition]);
        }
    }
}