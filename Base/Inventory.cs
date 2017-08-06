using System;
using System.Collections.Generic;
using DotNetGame.Creatures;
using DotNetGame.Items;

namespace DotNetGame
{
    public class Inventory
    {
        public float maxWeight { get; } //максимально возможный переносимый вес
        public int numberOfSlots { get;  } //количество слотов в инвентаре
        public Creature owner { get; private set; } //владелец текущего инвентаря 
        private List<Item> inventory; //список предметов в инвентаре 
        public float currentWeight { get; private set; } //текущий вес груза
        public int numberOfBusySlots { get; private set;  } //количество занятых слотов 
        
        //функция кладет предмет в инвентарь, а если не может, то кидает какаху
        public void add(Item item) 
        {
            if ((numberOfBusySlots + item.NumberOfSlots > numberOfSlots) || (currentWeight + item.Weight > maxWeight))
            {
                throw new Exception(numberOfBusySlots + item.NumberOfSlots > numberOfSlots?"Предмет занимает слишком много слотов":"Предмет имеет слишком большой вес");
            }
            else
            {
                currentWeight += item.Weight;
                numberOfBusySlots += item.NumberOfSlots;
                inventory.Add(item);
            }
        }
        
        //функция удаляет предмет из инвентаря, а если его там нет, то кидает какаху
        public void remove(Item item)
        {
            if (inventory.Contains(item))
            {
                inventory.Remove(item);
                currentWeight -= item.Weight;
                numberOfBusySlots -= item.NumberOfSlots;
            }
            else
            {
                throw new Exception("В этом инвентаре нет такого предмета");
            }
        }

        public Item get(int item)
        {
            return inventory[item];
        }
    }
}