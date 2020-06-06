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
			enemySpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/EnemyTextures");


		}

		public ISprite CreateSpriteEnemyAquamentus()
		{
			return new SpriteEnemyAquamentus(enemySpriteContent["EnemyAquamentus"]);
		}

		/*public ISprite CreateSpriteEnemyAquamentusProjectile()
		{
			return new SpriteEnemyAquamentus(enemySpriteContent["EnemyAquamentus"]);

		}*/

		public ISprite CreateSpriteEnemyAquamentusMouthOpen()
		{
			return new SpriteEnemyAquamentusMouthOpen(enemySpriteContent["EnemyAquamentusMouthOpen"]);
		}

		public ISprite CreateSpriteEnemyDodongoDown()
		{
			return new SpriteEnemyDodongoDown(enemySpriteContent["EnemyDodongoDown"]);
		}
		public ISprite CreateSpriteEnemyDodongoDownPuffed()
		{
			return new SpriteEnemyDodongoDownPuffed(enemySpriteContent["EnemyDodongoDownPuffed"]);
		}

		public ISprite CreateSpriteEnemyDodongoLeft()
		{
			return new SpriteEnemyDodongoLeft(enemySpriteContent["EnemyDodongoLeft"]);
		}

		public ISprite CreateSpriteEnemyDodongoLeftPuffed()
		{
			return new SpriteEnemyDodongoLeftPuffed(enemySpriteContent["EnemyDodongoLeftPuffed"]);
		}

		public ISprite CreateSpriteEnemyDodongoRight()
		{
			return new SpriteEnemyDodongoRight(enemySpriteContent["EnemyDodongoRight"]);
		}

		public ISprite CreateSpriteEnemyDodongoRightPuffed()
		{
			return new SpriteEnemyDodongoRightPuffed(enemySpriteContent["EnemyDodongoRightPuffed"]);
		}
		public ISprite CreateSpriteEnemyDodongoUp()
		{
			return new SpriteEnemyDodongoUp(enemySpriteContent["EnemyDodongoUp"]);
		}

		public ISprite CreateSpriteEnemyDodongoUpPuffed()
		{
			return new SpriteEnemyDodongoUpPuffed(enemySpriteContent["EnemyDodongoUpPuffed"]);
		}

		public ISprite CreateSpriteEnemyGel()
		{
			return new SpriteEnemyGel(enemySpriteContent["EnemyGel"]);
		}

		/*public ISprite CreateSpriteEnemyGoriyaWalkDown()
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
		}*/

		public ISprite CreateSpriteEnemyKeese()
		{
			return new SpriteEnemyKeese(enemySpriteContent["EnemyKeese"]);
		}

		/*public ISprite CreateSpriteEnemyRopeLeft()
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
