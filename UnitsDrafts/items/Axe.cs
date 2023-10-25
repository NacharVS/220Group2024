using System.Security.Cryptography.X509Certificates;

namespace UnitsDrafts.items
{
    internal class Axe : Weapon
    {
        public Axe(int minDamage, int maxDamage, int attackSpeed) : base(2, 9, 5) 
        {
        } 
        public override int Hit()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }
    }
}
