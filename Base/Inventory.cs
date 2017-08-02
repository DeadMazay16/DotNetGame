namespace DotNetGame
{
    public class Inventory
    {
        public float maxWeight { get; } //максимально возможный переносимый вес
        public int numberOfSlots { get;  } //количество слотов в инвентаре

        public Inventory(float maxWeight, int numberOfSlots){
            this.maxWeight = maxWeight;
            this.numberOfSlots = numberOfSlots;
        }
    }
}