using DotNetGame.Interfeses;

namespace DotNetGame.Items.Equipment
{
    public abstract class Equipment:Item
    {
        protected string slot;//слот, который занимает этот предмет
        protected IIntelligent owner;//существо-носитель
        protected string type;//тип данной шмотки
        protected int quality;//качество данной шмотки
        protected int level;//уровень шмота, на основе которого считаются бонусы 
        
        protected Equipment(string name, float weight, int numberOfSlots, string slot, IIntelligent owner, string type, int quality,int level) : base(name, weight, numberOfSlots)
        {
            this.slot = slot;
            this.owner = owner;
            this.quality = quality;
            this.type = type;
            this.level = level;
        }

        //получение баффов и дебаффов при надевании шмотки 
        protected abstract void equiped();

        //отключение баффов и дебаффов при снятии шмотки
        protected abstract void unequiped();
    }
}