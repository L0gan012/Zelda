using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Block
{
    class BlockLoadAllContent
    {

        //Instance variables
        Game1 game;

        public BlockLoadAllContent(Game1 game)
        {
            this.game = game;
        }

        //Initailizes all game items
        public void LoadContent()
        {
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteStatue());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteSquare());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteWall());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLockedDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteOpenDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteShutDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteStairs());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLadderTile());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteBrickTile());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteBombedOpening());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteGapTile());
        }
    }
}
