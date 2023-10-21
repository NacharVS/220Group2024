//using UnitsDrafts;

//List<Unit> units = new List<Unit>();
//units.Add(new Footman());
//units.Add(new Peasant());
//units.Add(new Archer()); 
//units.Add(new Peasant());
//units.Add(new Archer());
//units.Add(new Footman());
//units.Add(new Footman());
//units.Add(new Archer());

//if (units.Exists(x => x.Name == "Footman"))
//{
//    var founded = units.Find(x => x.Name == "Footman");
//    var index = units.FindIndex(1 , 4 , x => x.Name == "Footman");
//    founded?.ShowInfo();
//    units[1].ShowInfo();
//}


using UnitsDrafts;

Footman ft = new Footman(2, 5);
Archer archer = new Archer(3, 4);
Bishop bs = new Bishop(20);
ft.InflictDamage(archer);
ft.ShowInfo();
archer.ShowInfo();
bs.HealSomebody(archer);
archer.ShowInfo();
bs.ShowInfo();












