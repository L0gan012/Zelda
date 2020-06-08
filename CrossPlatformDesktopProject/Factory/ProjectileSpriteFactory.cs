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

	public class ProjectileSpriteFactory
	{
		//Instance variables
		//Dictionary populated with TextureContent class
		private Dictionary<string, Texture2D> projectileSpriteContent;
		private static ProjectileSpriteFactory instance = new ProjectileSpriteFactory();

		public static ProjectileSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private ProjectileSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			//Loads the Dictionary with all the item textures in ItemTextures folder
			projectileSpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/ProjectileTextures");
		}

		 
		public ISprite CreateSpriteProjectileAquamentus()
		{
			return new SpriteProjectileAquamentus(projectileSpriteContent["ProjectileAquamentus"]);
		}

		public ISprite CreateSpriteProjectileCandle()
		{
			return new SpriteProjectileCandle(projectileSpriteContent["ProjectileCandle"]);
			
		}

		public ISprite CreateSpriteProjectileFlame()
        {
			return new SpriteProjectileFlame(projectileSpriteContent["ProjectileFlame"]);

        }

		public ISprite CreateSpriteProjectileMagicBoomerang()
		{
			return new SpriteProjectileMagicBoomerang(projectileSpriteContent["ProjectileMagicBoomerang"]);
		}

		public ISprite CreateSpriteProjectileSilverArrowDown()
		{
			return new SpriteProjectileSilverArrowDown(projectileSpriteContent["ProjectileSilverArrowDown"]);

		}
		public ISprite CreateSpriteProjectileSilverArrowLeft()
		{
			return new SpriteProjectileSilverArrowLeft(projectileSpriteContent["ProjectileSilverArrowLeft"]);

		}

		public ISprite CreateSpriteProjectileSilverArrowRight()
		{
			return new SpriteProjectileSilverArrowRight(projectileSpriteContent["ProjectileSilverArrowRight"]);
		}
		public ISprite CreateSpriteProjectileSilverArrowUp()
		{
			return new SpriteProjectileSilverArrowUp(projectileSpriteContent["ProjectileSilverArrowUp"]);
		}

		public ISprite CreateSpriteProjectileWoodenArrowDown()
		{
			return new SpriteProjectileWoodenArrowDown(projectileSpriteContent["ProjectileWoodenArrowDown"]);
		}


		public ISprite CreateSpriteProjectileWoodenArrowLeft()
		{
			return new SpriteProjectileWoodenArrowLeft(projectileSpriteContent["ProjectileWoodenArrowLeft"]);
		}

		public ISprite CreateSpriteProjectileWoodenArrowRight()
		{
			return new SpriteProjectileWoodenArrowRight(projectileSpriteContent["ProjectileWoodenArrowRight"]);
		}


		/*public ISprite CreateSpriteProjectileWoodenArrowUp()
		{
			//return new SpriteProjectileWoodenArrowUp(projectileSpriteContent["ProjectileWoodenArrowUp"]);
		}*/

		public ISprite CreateSpriteProjectileWoodenBoomerang()
		{
			return new SpriteProjectileWoodenBoomerang(projectileSpriteContent["ProjectileWoodenBoomerang"]);
		}
	}
}
