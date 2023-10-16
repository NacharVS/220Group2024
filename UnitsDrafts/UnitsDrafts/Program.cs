using UnitsDrafts;

Footman ft1 = new Footman(13, 10);
Footman ft2 = new Footman(10, 10);
Peasant peasant = new Peasant();
Archer archer = new Archer();
Cleric cleric = new Cleric(50,60); 
ft1.InflictDamage(peasant);
peasant.BaseInfo();
ft1.InflictDamage(peasant);
peasant.BaseInfo();
cleric.Heal(peasant);
peasant.BaseInfo();
ft1.InflictDamage(peasant);
peasant.BaseInfo();
cleric.Heal(peasant);
peasant.BaseInfo();
ft1.InflictDamage(peasant);
peasant.BaseInfo();
ft1.InflictDamage(ft2);
ft1.InflictDamage(ft2);
ft1.InflictDamage(ft2);
ft1.InflictDamage(ft2);
ft1.InflictDamage(ft2);
ft1.InflictDamage(ft2);
ft1.InflictDamage(ft2);
ft2.BaseInfo();
ft2.InflictDamage(ft1);
ft1.BaseInfo();



