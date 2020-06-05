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


		public ISprite CreateLinkIdleLeftGreenSprite(Vector2 position)
		{
			return new SpriteLinkIdleLeftGreen(linkSpritesheet, position);
		}

		public ISprite CreateLinkIdleRightGreenSprite(Vector2 position)
		{
			return new SpriteLinkIdleRightGreen(linkSpritesheet, position);
		}

		public ISprite CreateLinkIdleUpGreenSprite(Vector2 position)
		{
			return new SpriteLinkIdleUpGreen(linkSpritesheet, position);
		}

		public ISprite CreateLinkIdleDownGreenSprite(Vector2 position)
		{
			return new SpriteLinkIdleDownGreen(linkSpritesheet, position);
		}

		public ISprite CreateMovingLeftLinkGreenSprite(Vector2 position)
		{
			return new SpriteLinkWalkLeftGreen(linkSpritesheet, position);
		}

		public ISprite CreateMovingRightLinkGreenSprite(Vector2 position)
		{
			return new SpriteLinkWalkRightGreen(linkSpritesheet, position);
		}

		public ISprite CreateMovingUpLinkGreenSprite(Vector2 position)
		{
			return new SpriteLinkWalkUpGreen(linkSpritesheet, position);
		}

		public ISprite CreateMovingDownLinkGreenSprite(Vector2 position)
		{
			return new SpriteLinkWalkDownGreen(linkSpritesheet, position);
		}

		public ISprite CreateAttackingLeftLinkGreenSprite(Vector2 position)
		{
			return new SpriteLinkAttackWoodenSwordLeftGreen(linkSpritesheet, position);
		}

		public ISprite CreateAttackingRightLinkGreenSprite(Vector2 position)
		{
			return;
		}

		public ISprite CreateAttackingUpLinkGreenSprite(Vector2 position)
		{
			return;
		}

		public ISprite CreateAttackingDownLinkGreenSprite(Vector2 position)
		{
			return;
		}
	}
}
