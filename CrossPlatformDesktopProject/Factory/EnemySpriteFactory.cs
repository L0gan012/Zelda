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
		//Instance variables
		//Dictionary populated with TextureContent class
		private Dictionary<string, Texture2D> enemySpriteContent;
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

		}

		public void LoadAllTextures(ContentManager content)
		{
			enemySpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/ItemTextures");


		}

		public ISprite CreateSpriteEnemyAquamentus()
		{
			return new SpriteEnemyAquamentus(enemySpriteContent["EnemyAquamentus"]);
		}

		/*public ISprite CreateSpriteEnemyAquamentusProjectile()
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
		}*/

	}
}
