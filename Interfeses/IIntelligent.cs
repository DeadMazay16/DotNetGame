using DotNetGame.Items.Equipment;

namespace DotNetGame.Interfeses
{
    public interface IIntelligent
    {
        Equipment getEquip(string slot);
        
        void equip(Equipment equiment);
        
        void unEquip(string slot);
    }
}