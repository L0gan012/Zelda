using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint2.Controller;
using Sprint2.Factory;
using Sprint2.Player;
using Sprint2.Item;
using System.Runtime.InteropServices;
using Sprint2.Enemy_NPC;

namespace Sprint2
{

    public class Game1 : Game
    {
        //Instance variables
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private ILink link;
        public IController controller;
        public static List<IItem> Items { get; set; }
        public static List<INPC> Enemies { get; set; }
        public static List<IBlock> Blocks { get; set; }
        public int ItemListPosition { get; set; }
        public int EnemyListPosition { get; set; }
        public int BlockListPosition { get; set; }
        public ItemLoadAllContent ItemLoader { get; set; }
        public EnemyLoadAllContent EnemyLoader { get; set; }
        public BlockLoadAllContent BlockLoader { get; set; }

        public List<IItem> ListOfItems
        { 
            get { return Items;}
            set { Items.Add((IItem)value); }
        }

        public List<INPC> ListOfEnemies
        {
            get { return Enemies; }
            set { Enemies.Add((IEnemy) value); }
        }

        public List<IBlock> ListOfBlocks
        {
            get { return Blocks; }
            set { Blocks.Add((IBlock)value); }
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

            //Registers Commands for controls
            controller.RegisterCommand();

            //Loads sprite content for link
            LinkSpriteFactory.Instance.LoadAllTextures(Content);

            //Initializes items objects
            Items = new List<IItem>();
            ItemLoader = new ItemLoadAllContent(this);

            //Initializes enemy and npc objects
            Enemies = new List<INPC>();
            EnemyLoader = new EnemyLoadAllContent(this);

            //Initializes blocks object
            Blocks = new List<IBlock>();
            BlockLoader = new BlockLoadAllContent(this);

           

            //Initializes list position
            ICommand reset = new ResetCommand(this);
            reset.Execute();
            

            base.Initialize();
        }

        //Initializes all of the drawable content
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Loads sprite content for items
            ItemsSpriteFactory.Instance.LoadAllTextures(Content);

            //Load sprite content for projectiles
            ProjectileSpriteFactory.Instance.LoadAllTextures(Content);

            //Enemy sprite content for items
            EnemySpriteFactory.Instance.LoadAllTextures(Content);

            //NPC sprite content for items
            NPCSpriteFactory.Instance.LoadAllTextures(Content);

            //Loads sprite content for blocks
            BlockSpriteFactory.Instance.LoadAllTextures(Content);

            //Loads content for all items
            ItemLoader.LoadContent();

            //Loads content for all enemies and npcs
            EnemyLoader.LoadContent();

            //Loads content for all blocks
            BlockLoader.LoadContent();
            
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
            Link.Update();
            //Updates items object
            Items[ItemListPosition].Update();
            //Updates items object
            Enemies[EnemyListPosition].Update();
            //Updates blocks object
            Blocks[BlockListPosition].Update();

            base.Update(gameTime);
         
        }

        //Draw
        protected override void Draw(GameTime gameTime)
        {
            //Set background color
            GraphicsDevice.Clear(Color.White);

            //Draws link
            link.Draw(spriteBatch);

            //Draws Items
            Items[ItemListPosition].Draw(spriteBatch);

            //Draws Enemies
            Enemies[EnemyListPosition].Draw(spriteBatch);

            //Draw blocks
            Blocks[BlockListPosition].Draw(spriteBatch, new Vector2(100, 100));

            base.Draw(gameTime);
        }

    }
}
