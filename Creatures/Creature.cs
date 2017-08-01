using System.Collections;
using System.Collections.Generic;

namespace DotNetGame.Creatures
{
    public class Creature : GameObject
    {
        public int Hp { get; private set; }
        private World world;
        private Inventory inventory;

        //Координаты существа в мире.
        private int x, y;
        
        public Creature(World world, string name, int hp, Inventory inventory) : base(name)
        {
            this.inventory = inventory;
            this.Hp = hp;
            this.world = world;
        }
        
        ///Базовое получение урона
        public void takeDamage(int damage)
        {
            Hp -= damage;
        }

        //Получить локацию, в которой находится существо по его текущим координатам. 
        public Location getLocation()
        {
            return world.getLocation(x, y);
        }
    }
}