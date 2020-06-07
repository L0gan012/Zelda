using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Enemy;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Enemy_NPC
{
    /// <summary>
    /// Class to load all enemys into games item list
    /// </summary>
    public class EnemyLoadAllContent
    {
        //Instance variables
        Game1 game;
        
        public EnemyLoadAllContent(Game1 game)
        {
            this.game = game;
        }

        //Initailizes all game items
        public void LoadContent()
        {
            game.ListOfEnemies.Add(new Aquamentus());
            //game.ListOfEnemies.Add(new OldMan());
            //game.ListOfEnemies.Add(new Dodongo());
            game.ListOfEnemies.Add(new Gel());
            game.ListOfEnemies.Add(new SpikeCross());
            game.ListOfEnemies.Add(new Keese());
            game.ListOfEnemies.Add(new Stalfos());

            
        }
    }
}
