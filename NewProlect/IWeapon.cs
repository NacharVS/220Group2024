namespace NewProlect
{
    public interface IWeapon
    {
        public int MinDamage { get; }
        public int MaxDamage { get; }

        public void Shoot();
    }
}