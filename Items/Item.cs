namespace DotNetGame.Items
{
    public class Item:GameObject 
    {
        private float weight;
        private int numberOfSlots;

        public Item(string name, float weight, int numberOfSlots) : base(name)
        {
            this.weight = weight;
            this.numberOfSlots = numberOfSlots;
        }
    }
}