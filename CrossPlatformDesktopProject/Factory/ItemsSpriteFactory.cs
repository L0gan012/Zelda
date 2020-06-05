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
		//private Texture2D itemSpriteContent;
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
			//This is for changing over to multiple sprite sheets 
			//itemSpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/ItemTextures");
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

		public ISprite CreateSpritePowerBracelet()
		{
			//return new SpriteCandle ();
		}
		public ISprite CreateSpriteRaft()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteRedPotion()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteRupee()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteSilverArrow()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteWhiteSword()
		{
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteWoodenArrow()
		{
			//return new SpriteCandle ();
		}
	}
}
