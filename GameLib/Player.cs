using System;
namespace GameLib
{
    public class Player
    {
        private static int instances = 0;
        private int x;
        public int X { get; set; }
        private int y;
        private int Y { get; set; }
        
        
        public Player()
        {
            instances++;
            Random rnd = new Random();
            x = rnd.Next(-25, 25);
            y = rnd.Next(-15, 15);
        }

        ~Player()
        {
            instances--;
        }
    }
}