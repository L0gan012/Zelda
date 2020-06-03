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
	public class BlockSpriteFactory
	{
		private Texture2D blockSpritesheet;
		private static BlockSpriteFactory instance = new BlockSpriteFactory();

		public static BlockSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private BlockSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			blockSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			// More Content.Load calls follow
			//...
		}

		// More public ISprite returning methods follow
		// ...
		/*public ISprite CreateSmallBlockSprite()
		{
			return new BlockSprite(lockSpritesheet, 32, 32);
		}*/
	}
}
