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

	public class ItemsSpriteFactory
    {
		//Instance variables
		private Texture2D itemsSpritesheet;
		private static ItemsSpriteFactory instance = new ItemsSpriteFactory();

		public static ItemsSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private ItemsSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			itemsSpritesheet = content.Load<Texture2D>("TextureSheets/LinkSpriteSheet");
		}

		 
		public ISprite CreateSpriteBlueCandle()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteBluePotion()
		{
			//return new SpriteCandle ();
		}

        public ISprite CreateSpriteBlueRing()
        {
            //return new SpriteCandle ();
        }

		public ISprite CreateSpriteBomb()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteBow()
		{
			//return new SpriteCandle ();
		}
		public ISprite CreateSpriteClock()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteCompass()
		{
			//return new SpriteCandle ();
		}
		public ISprite CreateSpriteFairy()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteRupee()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteFlute()
		{
			//return new SpriteCandle ();
		}


		public ISprite CreateSpriteHeartContainer()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteHeartKey()
		{
			//return new SpriteCandle ();
		}


		public ISprite CreateSpriteLadder()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteMagicBoomerang()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteMagicRod()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteMagicShield()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteMap()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpritePotionNote()
		{
			//return new SpriteCandle ();
		}


	}
}
