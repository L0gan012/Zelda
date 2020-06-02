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


		public ISprite CreateLinkIdleLeftGreenSprite()
		{
			return new SpriteLinkIdleLeftGreen();
		}

		public ISprite CreateLinkIdleRightGreenSprite()
		{
			return new SpriteLinkIdleRightGreen();
		}

		public ISprite CreateLinkIdleUpGreenSprite()
		{
			return new SpriteLinkIdleUpGreen();
		}

		public ISprite CreateLinkIdleDownGreenSprite()
		{
			return new SpriteLinkIdleDownGreen();
		}

		public ISprite CreateMovingLeftLinkSprite()
		{
			return new SpriteLinkWalkLeftGreen();
		}

		public ISprite CreateMovingRightLinkSprite()
		{
			return new SpriteLinkWalkRightGreen();
		}

		public ISprite CreateMovingUpLinkSprite()
		{
			return new SpriteLinkWalkUpGreen();
		}

		public ISprite CreateMovingDownLinkSprite()
		{
			return new SpriteLinkWalkDownGreen();
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
