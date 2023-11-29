using UnitsDrafts.Items;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {

        public Action action;
        public delegate void InflictDamageDelegate(Unit unit);
        public InflictDamageDelegate infDamage;
        private int _defence;
        private Weapon _weapon;

        public override int Health
        {
            get => base.Health;
            set => base.Health = value;
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public Footman(string name, int maxHealth, int speed, int damage, int defence)
            : base(name, maxHealth, speed)
        {

            _defence = defence;
        }

        public Footman() : base("Footman", 60, 10)
        {
            _defence = 2;
            _weapon = new Axe(2, 7, 5);
        }

        public void InflictDamage(Unit unit)
        {
            infDamage(unit);
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {_weapon.MaxDamage} Defence: {Defence}");
            action();
        }
    }

}
