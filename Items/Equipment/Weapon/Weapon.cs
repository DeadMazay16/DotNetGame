using System.Dynamic;
using DotNetGame.Interfeses;

namespace DotNetGame.Items.Equipment.Weapon
{
    public abstract class Weapon:Equipment
    {
        protected Weapon(string name, float weight, int numberOfSlots, IIntelligent owner, string type, int quality, int level) : base(name, weight, numberOfSlots, "weapon", owner, type, quality, level)
        {
        }

        protected abstract override void equiped();

        protected abstract override void unequiped();
    }
}