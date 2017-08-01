using System.Collections.Generic;
using DotNetGame.Creatures;
using DotNetGame.Items;

namespace DotNetGame
{
    public class Location
    {
        private int x, y;

        private List<Creature> members;    // Существа в локации.
        private List<Item>     items;      // Предметы, лежащие в локации.
        
        public Location(int x, int y, int level)
        {
            items      = new List<Item>();           
            members    = new List<Creature>();
            Level      = level;
            this.x     = x;
            this.y     = y;
        }

        //Уровень локации, на основании которого высчитываются параметры монстров в ней.
        public int Level { get; }

        //Массив получается для того, чтобы шаловливые ручки не смогли добавить в локальный список и изменить Count
        public Creature[] getCreatures()
        {
            return members.ToArray();
        }
        
        public Item[] getItems()
        {
            return items.ToArray();
        }

        public void addMember(Creature member)
        {
            members.Add(member);
        }

        public void addItem(Item item)
        {
            items.Add(item);
        }
    }
}