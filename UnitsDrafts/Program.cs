﻿using UnitsDrafts;


Barracks barracks = new Barracks();
Footman ft1 = barracks.CreateFootman();
Footman ft2 = barracks.CreateFootman();
Peasant peasant = barracks.CreatePeasant();
Archer archer = barracks.CreateArcher();
Cleric cleric = barracks.CreateCleric();
BuildingFactory factory = new BuildingFactory();
List<Archer> Units = new List<Archer>();
Units.Add(archer);
WatchingTower MegaUberBashnya = factory.BuildTower(Units, 1);
MegaUberBashnya.ShowInfo();
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















