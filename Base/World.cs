namespace DotNetGame
{
    public class World
    {
        public int SIZE_X, SIZE_Y;

        private Location[ , ] world;
        
        public World(int x, int y)
        {
            SIZE_X    = x;
            SIZE_Y    = y;
            world     = new Location[x,y];
        }

        public void init()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    world[i,j] = new Location(j, i, 0);
                }
            }
        }

        public Location getLocation(int x, int y)
        {
            return world[y, x];
        }
    }
}