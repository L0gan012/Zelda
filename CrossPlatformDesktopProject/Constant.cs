﻿using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public static class Constant
    {
        //TODO: (Barry)  These are temporary fixed values for testing only.  
        public static readonly int ScreenWidth = 800;
        public static readonly int ScreenHeight = 480;
        public static readonly Vector2 LinkStartPosition = new Vector2(200, 200);
        public static readonly Vector2 ItemStartPosition = new Vector2(400, 200);
        public static readonly Vector2 EnemyStartPosition = new Vector2(600, 200);
        public static readonly int AquamentusXRange = 40;
        

        public static readonly int FramesPerSecond = 60;

        //Animation Speed setting
        public static readonly int TicksPerFrameWalk = 8;
        public static readonly int TicksPerFrameAttackSword = 4;

        //One game grid square is 16*16 pixels.  DisplayScales multiply output size
        public static readonly int DisplayScaleX = 3;
        public static readonly int DisplayScaleY = 3;

        //Link Damaged time
        public static readonly int DamagedTime = 25;

        //random number generator
        public static readonly Random RNG = new Random();

    }
}

