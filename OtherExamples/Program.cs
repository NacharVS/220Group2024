using OtherExamples;
using UnitsDrafts;

GenegicArray<Unit> units = new GenegicArray<Unit>();
units.AddProducts(new Footman());
units.AddProducts(new Footman());


var list = units.GetArray();
foreach (var unit in list)
{
    Console.WriteLine(unit.Name);
}



Console.WriteLine("Hello, World!");
