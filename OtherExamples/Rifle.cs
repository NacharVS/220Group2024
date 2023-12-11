namespace OtherExamples
{
    internal class Rifle : Weapon, IWeapon
    {
        public int MinDamage  => 5; 
        public int MaxDamage => 12; 

        public void Shoot()
        {
            Console.WriteLine($"bum-bum! dealed {new Random().Next(MinDamage, MaxDamage)} of damage");
        }
    }
}
