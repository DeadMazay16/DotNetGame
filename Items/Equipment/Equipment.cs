using DotNetGame.Interfeses;

namespace DotNetGame.Items.Equipment
{
    public abstract class Equipment:Item
    {
        protected string slot;//слот, который занимает этот предмет
        protected IIntelligent owner;//существо-носитель
        
        protected Equipment(string name, float weight, int numberOfSlots, string slot, IIntelligent owner) : base(name, weight, numberOfSlots)
        {
            this.slot = slot;
            this.owner = owner;
        }

        //получение баффов и дебаффов при надевании шмотки 
        protected abstract void equiped();

        //отключение баффов и дебаффов при снятии шмотки
        protected abstract void unequiped();
    }
}
