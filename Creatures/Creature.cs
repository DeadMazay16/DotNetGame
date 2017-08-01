using System;
using System.Collections;
using System.Collections.Generic;
using DotNetGame.Items;

namespace DotNetGame.Creatures
{
    public class Creature : GameObject
    {
        //Лог событий
        private List<string> log;

        public string[] getLog()
        {
            return log.ToArray();
        }

        public void addToLog(string msg)
        {
            log.Add(msg);
        }

        private bool alive;
        public int Hp { get; private set; }
        private int maxHp;
        private World world;
        private Inventory inventory;

        
        
        //Координаты существа в мире.
        private int x, y;
        
        public Creature(World world, string name, int hp, Inventory inventory, int x, int y) : base(name)
        {
            //При создании добавляем существо в локацию, в которой он был создан
            world.getLocation(x, y).addMember(this);
            
            log = new List<string>();
            this.alive = true;
            this.inventory = inventory;
            maxHp = hp;
            this.Hp = hp;
            this.world = world;
        }
        
        //Базовое получение урона
        public void takeDamage(int damage)
        {
            Hp -= damage;
            addToLog("Получено " + damage + "едениц урона");
            if (Hp <= 0)
            {
                alive = false;
                addToLog("Умер");
            }
        }

        public bool isAlive()
        {
            return alive;
        }

        //Получить локацию, в которой находится существо по его текущим координатам. 
        public Location getLocation()
        {
            return world.getLocation(x, y);
        }

        public void addItem(Item item)
        {
            try
            {
                inventory.add(item);
            }
            catch (Exception e)
            {
                addToLog(e.Message);
            }
            
        }
    }
}