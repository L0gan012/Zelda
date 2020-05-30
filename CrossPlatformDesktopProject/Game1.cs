using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint0
{
    public class Game1 : Game
    {
        //Instance variables
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont spriteFont;
        private Texture2D texture;

        private List<IController> controllers;
        private Dictionary<Keys, ICommand> keyboardCommands;

        private ISprite sprite;
        
        //Game constructor
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        //Initailizes all non-drawable content
        protected override void Initialize()
        {
            //Make the mouse visible
            this.IsMouseVisible = true;

            //Make a dictionary of the keys and commands
            keyboardCommands = new Dictionary<Keys, ICommand>();
            keyboardCommands.Add(Keys.D0, new ExitCommand(this));
            keyboardCommands.Add(Keys.D1, new StationarySpriteCommand(this));
            keyboardCommands.Add(Keys.D2, new AnimatedSpriteCommand(this));
            keyboardCommands.Add(Keys.D3, new MovingSpriteCommand(this));
            keyboardCommands.Add(Keys.D4, new AnimatedMovingSpriteCommand(this));

            //Make a list of controllers used
            controllers = new List<IController>();

            //Add a keyboard and a mouse controller
            controllers.Add(new KeyboardController(keyboardCommands));

            base.Initialize();
        }

        //Initializes all of the drawable content
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Load Sprite Sheet and Sprite font from the content file
            spriteFont = Content.Load<SpriteFont>("Fonts/Font");
            texture = Content.Load<Texture2D>("TextureSheets/LinkSpriteSheet");

            //Initialize the starting sprite to the stationary sprite
            sprite = new StationarySprite(this.GraphicsDevice.Viewport.Width, this.GraphicsDevice.Viewport.Height);
        }

        //Unloads content
        protected override void UnloadContent()
        {
            Content.Unload();
        }

        //Update
        protected override void Update(GameTime gameTime)
        {
            //Loops through all the controllers and updates each of them
            foreach(IController controller in controllers)
            {
                controller.Update();
            }

            //Updates the sprite
            sprite.Update();

            base.Update(gameTime);
        }

        //Draw
        protected override void Draw(GameTime gameTime)
        {
            //Set background color
            GraphicsDevice.Clear(Color.White);

            //Draw the current sprite and text to the screen
            sprite.Draw(spriteBatch, texture);
            textSprite.Draw(spriteBatch, texture);

            base.Draw(gameTime);
        }

        //Sets the current sprite
        public void setSprite(ISprite sprite)
        {
            this.sprite = sprite;
        }
    }
}
