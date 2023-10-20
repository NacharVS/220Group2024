using UnitsDrafts;

List<Unit> units = new List<Unit>();
units.Add(new Footman());
units.Add(new Peasant());
units.Add(new Archer()); 
units.Add(new Peasant());
units.Add(new Archer());
units.Add(new Footman());
units.Add(new Footman());


if (units.Exists(x => x.Name == "Footman"))
{
    var founded = units.Find(x => x.Name == "Footman");
    var index = units.FindIndex(1 , 4 , x => x.Name == "Footman");
    founded?.ShowInfo();
    units[1].ShowInfo();
}















