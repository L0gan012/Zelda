﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    interface IEnemy
    {
        //Updates the Enemy
        void Update();

        //Draws the enemy
        void Draw(SpriteBatch spriteBatch, Texture2D texture);
    }
}