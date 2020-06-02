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

	public class LinkSpriteFactory
    {
		private Texture2D linkSpritesheet;
		private static LinkSpriteFactory instance = new LinkSpriteFactory();

		public static LinkSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private LinkSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			linkSpritesheet = content.Load<Texture2D>("TextureSheets/LinkSpriteSheet");
		}

		//Todo: Load Sprite
		//Method is place holder for common factory methods
		/*public ISprite CreateSmallEnemySprite()
		{
			return new EnemySprite(enemySpritesheet, 32, 32);
		}*/

		public ISprite CreateMovingLeftLinkSprite()
		{
			return new SpriteLinkIdleLeftGreen();
		}

		public ISprite CreateMovingRightLinkSprite()
		{
			return new SpriteLinkIdleRightGreen();
		}

		public ISprite CreateMovingUpLinkSprite()
		{
			return new SpriteLinkIdleUpGreen();
		}

		public ISprite CreateMovingDownLinkSprite()
		{
			return new SpriteLinkIdleDownGreen();
		}

		public ISprite CreateAttackingLeftLinkSprite()
		{
			return;
		}

		public ISprite CreateAttackingRightLinkSprite()
		{
			return;
		}

		public ISprite CreateAttackingUpLinkSprite()
		{
			return;
		}

		public ISprite CreateAttackingDownLinkSprite()
		{
			return;
		}
	}
}
