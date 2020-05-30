using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint2.Controller;
using Sprint2.Factory;

namespace Sprint2
{
    public class Game1 : Game
    {
        //Instance variables
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        public IController controller;
        public IPlayer link;


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

            //Initializes controller object
            controller = new KeyboardController(this);

            //Initializes player object
            link = new Link();

            base.Initialize();
        }

        //Initializes all of the drawable content
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            //Loads sprite content for link
            LinkSpriteFactory.Instance.LoadAllTextures(Content);

            //Registers Commands for controls
            controller.RegisterCommand();
        }

        //Unloads content
        protected override void UnloadContent()
        {

        }

        //Update
        protected override void Update(GameTime gameTime)
        {
            //Updates contols
             controller.Update();
            //Updates link object
            link.Update();
            base.Update(gameTime);
         
        }

        //Draw
        protected override void Draw(GameTime gameTime)
        {
            //Set background color
            GraphicsDevice.Clear(Color.White);
            //link.Draw();
            base.Draw(gameTime);
        }

    }
}
