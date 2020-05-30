namespace Sprint2.Command
{
    class ExitCommand : ICommand
    {
        //Instance variables
        private Game1 game;

        //Constructor with game instance parameter
        public ExitCommand(Game1 game)
        {
            this.game = game;
        }

        //Exits the game
        public void Execute()
        {
            this.game.Exit();
        }
    }
}
