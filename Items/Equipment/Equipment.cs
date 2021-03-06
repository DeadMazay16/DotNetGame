﻿using DotNetGame.Creatures;
using DotNetGame.Interfeses;

namespace DotNetGame.Items.Equipment
{
    public abstract class Equipment:Item
    {
        protected string slot;//слот, который занимает этот предмет
        protected string type;//тип данной шмотки
        protected Creature owner;//владелец шмотки
        protected int quality;//качество данной шмотки
        protected int level;//уровень шмота, на основе которого считаются бонусы 
        
        protected Equipment(string name, float weight, int numberOfSlots, string slot, string type, int quality,int level) : base(name, weight, numberOfSlots)
        {
            this.slot = slot;
            this.quality = quality;
            this.type = type;
            this.level = level;
        }

        //задает владельца для шмотки 
        public void assignOwner(Creature owner)
        {
            this.owner = owner;
        }
        
        //получение баффов и дебаффов при надевании шмотки 
        protected abstract void equiped();

        //отключение баффов и дебаффов при снятии шмотки
        protected abstract void unequiped();
    }
}