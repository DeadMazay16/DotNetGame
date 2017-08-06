using DotNetGame.Interfeses;

namespace DotNetGame.Items.Equipment.Weapon.SharpWeapon
{
    public class Sward : Weapon
    {
        public Sward(string name, float weight, int numberOfSlots, IIntelligent owner, string type, int quality, int level, string damageType) : base(name, weight, numberOfSlots, owner, type, quality, level, damageType)
        {
        }

        protected override void equiped()
        {
            throw new System.NotImplementedException();
        }

        protected override void unequiped()
        {
            throw new System.NotImplementedException();
        }
    }
}
}