using System;

namespace Sprint0
{
    public class Class1
    {
        public static readonly int ScreenWidth = 800;
        public static readonly int ScreenHeight = 480;
        public static readonly Vector2 LinkStartPosition = new Vector2(200, 200);
        public static readonly Vector2 EnemyStartPosition = new Vector2(600, 200);

        //Animation Speed setting
        public static readonly int TicksPerFrame = 8;

        //One game grid square is 16*16 pixels.  DisplayScales multiply output size
        public static readonly int DisplayScaleX = 3;
        public static readonly int DisplayScaleY = 3;


    }
}

