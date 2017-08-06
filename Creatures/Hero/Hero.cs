namespace DotNetGame.Creatures.Hero
{
    public class Hero:Creature
    {
        public int currentLevel { get; private set; }//уровень нашего героя
        public int currentExp { get; private set; }//текущее количество экспы
        public int expToNextLvl { get; private set; }//количество экспы для ЛВЛапа

        public Hero(World world, string name, int hp, Inventory inventory, int x, int y) : base(world, name, hp, inventory, x, y)
        {
            this.currentLevel = 1;
            this.currentExp = 0;
            this.expToNextLvl = 100;
        }

        public void lvlUp()
        {
            if (currentExp < expToNextLvl) return; 
            this.currentLevel++;
            Core.out_message("Ваш герой получил " + currentLevel + " уровень!");
            this.expToNextLvl += this.expToNextLvl / 2;
            if (expToNextLvl % 10 > 0) expToNextLvl = expToNextLvl / 10 * 10 + 10; // округление в сторону числа на 0
        }

        public void giveSomeExp(int someExp)
        {
            Core.out_message("Ваш герой получил " + someExp + " опыта");
            this.currentExp += someExp;
            lvlUp();
        }
    }
}