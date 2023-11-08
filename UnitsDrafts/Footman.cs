namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private double _damage;
        private double _defence;
        private double _health;
        private double _maxHealth;


        public Footman(string name, int health, int maxHealth, int speed, int damage, int defence) : base(name, health, maxHealth, defence)
        {
            _damage = damage;
            _defence = defence;
            _health = health;
        }

        public Footman() : base("Footman", 60, 60, 20)
        {
            Damage = 15;
            Defence = 30;
        }        
    }
}
