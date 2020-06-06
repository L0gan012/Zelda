using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.Sprite;

namespace Sprint2.Factory
{
	public class EnemySpriteFactory
	{
		private List<Texture2D> enemySpritesheetList;
		private static EnemySpriteFactory instance = new EnemySpriteFactory();


        public static EnemySpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private EnemySpriteFactory()
		{
			enemySpritesheetList = new List<Texture2D>();
		}

		public void LoadAllTextures(ContentManager content)
		{
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyAquamentus"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyAquamentusMouthOpen"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyDodongoDown"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyDodongoDownPuffed"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyDodongoLeft"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyDodongoLeftPuffed"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyDodongoRight"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyDodongoRightPuffed"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyDodongoUp"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyDodongoUpPuffed"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyGel"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyGoriyaWalkDown"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyGoriyaWalkLeft"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyGoriyaWalkRight"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyGoriyaWalkUp"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyKeese"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyRopeLeft"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyRopeRight"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemySpikeCross"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyStalfos"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyWallmasterLeft"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyWallmasterRight"));
			enemySpritesheetList.Add(content.Load<Texture2D>("TextureSheets/EnemyZol"));

		}

		public ISprite CreateSpriteEnemyAquamentus()
		{
			return new SpriteEnemyAquamentus(enemySpritesheetList[0]);
		}

		public ISprite CreateSpriteEnemyAquamentusProjectile()
		{
		}

		public ISprite CreateSpriteEnemyAquamentusMouthOpen()
		{
			return new SpriteEnemyAquamentusMouthOpen(enemySpritesheetList[2]);
		}

		public ISprite CreateSpriteEnemyDodongoDown()
		{
			return new SpriteEnemyDodongoDown(enemySpritesheetList[3]);
		}
		public ISprite CreateSpriteEnemyDodongoDownPuffed()
		{
			return new SpriteEnemyDodongoDownPuffed(enemySpritesheetList[4]);
		}

		public ISprite CreateSpriteEnemyDodongoLeft()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyDodongoLeftPuffed()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyDodongoRight()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyDodongoRightPuffed()
		{
			//return new SpriteCandle ();
		}
		public ISprite CreateSpriteEnemyDodongoUp()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyDodongoUpPuffed()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyGel()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyGoriyaWalkDown()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyGoriyaWalkLeft()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyGoriyaWalkUp()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyKeese()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyRopeLeft()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyRopeRight()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemySpikeCross()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyStalfos()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyWallmasterLeft()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyWallmasterRight()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteEnemyZol()
		{
			//return new SpriteCandle ();
		}

	}
}
