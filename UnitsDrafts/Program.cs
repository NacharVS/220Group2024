using UnitsDrafts;

Footman ft1 = new Footman();
Footman ft2 = new Footman();



ft2.HealthDecreasedEvent += (Unit sender, UnitEventArg e) =>
{
    Console.WriteLine($"{sender.Name} {e.Message} {e.HealthDifferce} current health: {sender.Health}");
};

ft2.HealthIncreasedEvent += (Unit sender, UnitEventArg e) =>
{
    Console.WriteLine($"{sender.Name} {e.Message} {e.HealthDifferce}");
};
ft1.infDamage = (Unit unit) =>
{
    unit.Health -= 10;
    unit.Health -= 10;
    unit.Health -= 10;
};
ft1.InflictDamage(ft2);














