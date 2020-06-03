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

		/*Todo Add methods for loading new item sprites. 
		public ISprite CreateSpriteBoomerang(This is a test method name)()
		{
			return new SpriteBoomerang();
		}*/
	}
}
