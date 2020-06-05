using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint2.Controller;
using Sprint2.Factory;
using Sprint2.Player;
using Sprint2.Item;
using Sprint2.Block;
using System.Runtime.InteropServices;

namespace Sprint2
{
    public class Game1 : Game
    {
        //Instance variables
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private ILink link;
        public IController controller;
        private static List<IItem> items;
        private static List<INPC> enemies;
        private static List<IBlock> blocks;
        public int itemListPosition;
        public int enemylistPosition;
        public int blockListPosition;
        private ItemLoadAllContent itemLoader;
        private EnemyLoadAllContent enemyLoader;
        private BlockLoadAllContent blockLoader;

        public List<IItem> ListOfItems
        { 
            get { return items;}
            set { items.Add((IItem)value); }
        }

        public List<INPC> ListOfEnemies
        {
            get { return enemies; }
            set { enemies.Add((IEnemy) value); }
        }

        public List<IBlock> ListOfBlocks
        {
            get { return blocks; }
            set { blocks.Add((IBlock)value); }
        }
        public ILink Link
        {
            get { return link; }
            set { link = value; }
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

            //Initializes blocks object
            blocks = new List<IBlock>();
            blockLoader = new BlockLoadAllContent(this);

            //Initializes player object
            link = new Link(this);

            //Registers Commands for controls
            controller.RegisterCommand();

            base.Initialize();
        }

        //Initializes all of the drawable content
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            //Loads sprite content for link
            LinkSpriteFactory.Instance.LoadAllTextures(Content);

            //Loads sprite content for blocks
            BlockSpriteFactory.Instance.LoadAllTextures(Content);


            //Loads content for all items
            itemLoader.LoadContent();
            enemyLoader.LoadContent();

            //Loads content for all blocks
            blockLoader.LoadContent();
            
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
            //Updates blocks object
            blocks[blockListPosition].Update();

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

            //Draw blocks
            blocks[blockListPosition].Draw(spriteBatch, new Vector2(100, 100));

            base.Draw(gameTime);
        }

    }
}
