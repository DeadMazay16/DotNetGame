using System.Collections.Generic;

namespace DotNetGame.Creatures
{
    public class Creature : GameObject
    {
        public int Hp { get; private set; }

        private Inventory inventory;

        public Creature(string name, int hp, Inventory inventory) : base(name)
        {
            this.inventory = inventory;
            this.Hp = hp;
        }

        public void takeDamage(int damage)
        {
            Hp -= damage;
        }
    }
}