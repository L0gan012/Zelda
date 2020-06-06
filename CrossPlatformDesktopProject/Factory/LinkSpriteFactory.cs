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
			return new SpriteLinkIdleLeftGreen(linkSpritesheet);
		}

		public ISprite CreateLinkIdleRightGreenSprite()
		{
			return new SpriteLinkIdleRightGreen(linkSpritesheet);
		}

		public ISprite CreateLinkIdleUpGreenSprite()
		{
			return new SpriteLinkIdleUpGreen(linkSpritesheet);
		}

		public ISprite CreateLinkIdleDownGreenSprite()
		{
			return new SpriteLinkIdleDownGreen(linkSpritesheet);
		}

		public ISprite CreateMovingLeftLinkGreenSprite()
		{
			return new SpriteLinkWalkLeftGreen(linkSpritesheet);
		}

		public ISprite CreateMovingRightLinkGreenSprite()
		{
			return new SpriteLinkWalkRightGreen(linkSpritesheet);
		}

		public ISprite CreateMovingUpLinkGreenSprite()
		{
			return new SpriteLinkWalkUpGreen(linkSpritesheet);
		}

		public ISprite CreateMovingDownLinkGreenSprite()
		{
			return new SpriteLinkWalkDownGreen(linkSpritesheet);
		}

		public ISprite CreateAttackingLeftLinkGreenSprite()
		{
			return new SpriteLinkAttackWoodenSwordLeftGreen(linkSpritesheet);
		}

		public ISprite CreateAttackingRightLinkGreenSprite()
		{
			return new SpriteLinkAttackWoodenSwordRightGreen(linkSpritesheet);
		}

		public ISprite CreateAttackingUpLinkGreenSprite()
		{
			return;
		}

		public ISprite CreateAttackingDownLinkGreenSprite()
		{
			return;
		}
	}
}
