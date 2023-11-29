using UnitsDrafts.items;

namespace UnitsDrafts
{
    internal class Barracs 
    {
        public delegate void StatisticsDelegate(int count);
        public Footman CreateFootman()
        {
            Random random = new Random();
            Statistics.FootmansCount++;
            return  new Footman("Footman", random.Next(50,60), random.Next(5, 10), random.Next(5, 15), random.Next(1, 4));
        }

        public Archer CreateArcher()
        {
            Statistics.ArchersCount++;
            return new Archer();
        }
        public void UpgradeWeapon(Weapon weapon)
        {
            if (weapon.Name == "axe")
            {
                if (weapon.Level == weapon.MaxLevel)
                {
                    Console.WriteLine("Max level reached");
                }
                else
                {
                    weapon.Level += 1;
                    weapon.MaxDamage += 2;
                    weapon.MinDamage += 2;
                    weapon.AttackSpeed += 2;
                }
            }
            if (weapon.Name == "bow")
            {
                if (weapon.Level == weapon.MaxLevel)
                {
                    Console.WriteLine("Max level reached");
                }
                else
                {
                    weapon.Level += 1;
                    weapon.MaxDamage += 4;
                    weapon.MinDamage += 4;
                    weapon.AttackSpeed += 1;
                }
            }
            if (weapon.Name == "staff")
            {
                if (weapon.Level == weapon.MaxLevel)
                {
                    Console.WriteLine("Max level reached");
                }
                else
                {
                    weapon.Level += 1;
                    weapon.MaxDamage += 1;
                    weapon.MinDamage += 1;
                }
            }
        }
    }
}