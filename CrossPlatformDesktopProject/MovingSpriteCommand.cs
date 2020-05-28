namespace Sprint0
{
    class MovingSpriteCommand : ICommand
    {
        //Instance variables
        private Game1 game;

        //Constructor with game instance parameter
        public MovingSpriteCommand(Game1 game)
        {
            this.game = game;
        }

        //Sets the corresponding sprite to be drawn
        public void Execute()
        {
            this.game.setSprite(new MovingSprite(this.game.GraphicsDevice.Viewport.Width, this.game.GraphicsDevice.Viewport.Height));
        }
    }
}
