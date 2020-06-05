using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.Sprite;
using Microsoft.Xna.Framework;

namespace Sprint2.Factory
{

	public class ItemsSpriteFactory
    {
		//Instance variables
		private Texture2D itemsSpritesheet;
		//Dictionary populated with TextureContent class
		private Dictionary<string, Texture2D> itemSpriteContent;
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
			//Loads the Dictionary with all the item textures in ItemTextures folder
			itemSpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/ItemTextures");
		}

		 
		public ISprite CreateSpriteBlueCandle(Vector2 position)
		{
			Texture2D texture = itemSpriteContent["ItemBlueCandle"];
			//return new SpriteCandle ();
			
		}

		public ISprite CreateSpriteBluePotion()
		{
			Texture2D texture = itemSpriteContent["ItemBluePotion"];
			//return new SpriteCandle ();
		}

        public ISprite CreateSpriteBlueRing()
        {
			Texture2D texture = itemSpriteContent["ItemBlueRing"];
            //return new SpriteCandle ();
        }

		public ISprite CreateSpriteBomb()
		{
			Texture2D texture = itemSpriteContent["ItemBomb"];
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteBow()
		{
			Texture2D texture = itemSpriteContent["ItemBow"];
			//return new SpriteCandle ();
		}
		public ISprite CreateSpriteClock()
		{
			Texture2D texture = itemSpriteContent["ItemClock"];
			//return new SpriteCandle ();
		}

		public ISprite CreateSpriteCompass()
		{
			//return new SpriteCandle ();
		}
		public ISprite CreateSpriteFairy()
		{
			return new SpriteContinuousAnimation(itemSpriteContent["ItemFairy"], 1, 2, 8);
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
