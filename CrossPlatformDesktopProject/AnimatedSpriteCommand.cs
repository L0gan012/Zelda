﻿namespace Sprint0
{
    class AnimatedSpriteCommand : ICommand
    {
        //Instance variables
        private Game1 game;

        //Constructor with game instance parameter
        public AnimatedSpriteCommand(Game1 game)
        {
            this.game = game;
        }

        //Sets the corresponding sprite to be drawn
        public void Execute()
        {
            this.game.setSprite(new AnimatedSprite(this.game.GraphicsDevice.Viewport.Width, this.game.GraphicsDevice.Viewport.Height));
        }
    }
}
