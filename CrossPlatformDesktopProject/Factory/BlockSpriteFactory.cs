using Microsoft.Xna.Framework.Content;
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
		private Texture2D ladderTileSpritesheet;
		private Texture2D brickTileSpritesheet;
		private Texture2D bombedOpeningSpritesheet;
		private Texture2D gapTileSpritesheet;

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
			statueSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Statue");
			squareSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Square");
			wallSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Wall");
			lockedDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/LockedDoor");
			openDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/OpenDoor");
			shutDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/ShutDoor");
			stairsSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Stairs");
			ladderTileSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Ladder");
			brickTileSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Brick");
			bombedOpeningSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/BombedOpening");
			gapTileSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Gap");
			// More Content.Load calls follow
			//...
		}

		public IBlock CreateSpriteStatue()
		{
			return new Blocks(statueSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteSquare()
		{
			return new Blocks(squareSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteWall()
		{
			return new Blocks(wallSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteLockedDoor()
		{
			return new Blocks(lockedDoorSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteOpenDoor()
		{
			return new Blocks(openDoorSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteShutDoor()
		{
			return new Blocks(shutDoorSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteStairs()
		{
			return new Blocks(stairsSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteLadderTile()
		{
			return new Blocks(ladderTileSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteBrickTile()
		{
			return new Blocks(brickTileSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteBombedOpening()
		{
			return new Blocks(bombedOpeningSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteGapTile()
		{
			return new Blocks(gapTileSpritesheet, 1, 1);
		}


	}
}
