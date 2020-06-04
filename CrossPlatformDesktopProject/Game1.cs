using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint2.Controller;
using Sprint2.Factory;
using Sprint2.Player;
using Sprint2.Item;
using System.Runtime.InteropServices;

namespace Sprint2
{
    public class Game1 : Game
    {
        //Instance variables
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        //TODO: make properties instead -Izzy
        public IPlayer link;
        public IController controller;
        private static List<IItem> items;
        private static List<IEnemy> enemies;
        public int itemListPosition;
        public int enemylistPosition;
        private ItemLoadAllContent itemLoader;
        private EnemyLoadAllContent enemyLoader;

        public List<IItem> ListOfItems
        { 
            get { return items;}
            set{ items.Add((IItem)value); }
        }

        public List<IEnemy> ListOfEnemies
        {
            get { return enemies; }
            set { enemies.Add((IEnemy) value); }
        }

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

            //Initializes items object
            items = new List<IItem>();
            itemLoader = new ItemLoadAllContent(this);
            enemyLoader = new EnemyLoadAllContent(this);


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

            //Loads content for all items
            itemLoader.LoadContent();
            enemyLoader.LoadContent();


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
            //Updates items object
            items[itemListPosition].Update();
            //Updates items object
            enemies[enemylistPosition].Update();

            base.Update(gameTime);
         
        }

        //Draw
        protected override void Draw(GameTime gameTime)
        {
            //Set background color
            GraphicsDevice.Clear(Color.White);
            //link.Draw();
            //items[itemListPosition].Draw(spriteBatch);
            //enemies[enemylistPosition].Draw(spriteBatch);
            base.Draw(gameTime);
        }

    }
}
