using System.Dynamic;
using DotNetGame.Interfeses;

namespace DotNetGame.Items.Equipment.Weapon
{
    public abstract class Weapon:Equipment
    {
        protected string damageType;

        protected Weapon(string name, float weight, int numberOfSlots, IIntelligent owner, string type, int quality, int level, string damageType) : base(name, weight, numberOfSlots, "weapon", owner, type, quality, level)
        {
            this.damageType = damageType;
        }

        protected abstract override void equiped();

        protected abstract override void unequiped();
    }
}