using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.Sprite;

namespace Sprint2
{
	public class NPCSpriteFactory
	{
		//Instance variables
		//Dictionary populated with TextureContent class
		private Dictionary<string, Texture2D> npcSpriteContent;
		private static NPCSpriteFactory instance = new NPCSpriteFactory();


		public static NPCSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private NPCSpriteFactory()
		{

		}

		public void LoadAllTextures(ContentManager content)
		{
			npcSpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/EnemyTextures");
		}

		/*public ISprite createNPCOldMan()
        {
			//return new 
		}*/

	}
}
