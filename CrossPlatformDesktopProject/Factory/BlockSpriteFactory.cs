﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.Sprite;
using Sprint2.Block;

namespace Sprint2.Factory
{
	public class BlockSpriteFactory
	{
		// All spritesheet instance listed here
		private Texture2D statueSpritesheet;
		private Texture2D squareSpritesheet;
		private Texture2D wallSpritesheet;
		private Texture2D lockedDoorSpritesheet;
		private Texture2D openDoorSpritesheet;
		private Texture2D shutDoorSpritesheet;
		private Texture2D stairsSpritesheet;
		private Texture2D ladderSpritesheet;
		private Texture2D brickSpritesheet;

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

		//Load all textures
		public void LoadAllTextures(ContentManager content)
		{
			statueSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			squareSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			wallSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			lockedDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			openDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			shutDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			stairsSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			ladderSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			brickSpritesheet = content.Load<Texture2D>("TextureSheets/BlockSpriteSheet");
			// More Content.Load calls follow
			//...
		}

		public ISprite CreateSpriteStatue()
		{
			return new Blocks(statueSpritesheet, 1, 1);
		}
		public ISprite CreateSpriteSquare()
		{
			return new Blocks(squareSpritesheet, 1, 1);
		}
		public ISprite CreateSpriteWall()
		{
			return new Blocks(wallSpritesheet, 1, 1);
		}
		public ISprite CreateSpriteLockedDoor()
		{
			return new Blocks(lockedDoorSpritesheet, 1, 1);
		}
		public ISprite CreateSpriteOpenDoor()
		{
			return new Blocks(openDoorSpritesheet, 1, 1);
		}
		public ISprite CreateSpriteShutDoor()
		{
			return new Blocks(shutDoorSpritesheet, 1, 1);
		}
		public ISprite CreateSpriteStairs()
		{
			return new Blocks(stairsSpritesheet, 1, 1);
		}
		public ISprite CreateSpriteLadder()
		{
			return new Blocks(ladderSpritesheet, 1, 1);
		}
		public ISprite CreateSpriteBrick()
		{
			return new Blocks(brickSpritesheet, 1, 1);
		}

	}
}
