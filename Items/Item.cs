namespace DotNetGame.Items
{
    public class Item:GameObject 
    {
        public float Weight { get; }
        public int NumberOfSlots { get; }

        public Item(string name, float weight, int numberOfSlots) : base(name)
        {
            this.Weight = weight;
            this.NumberOfSlots = numberOfSlots;
        }
    }
}