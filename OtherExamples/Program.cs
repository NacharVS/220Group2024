using OtherExamples;
using System.Collections;
using UnitsDrafts;

Users a = new Users();

List<string> array2 = new() { "qq", "dd", "dffdf", "fdf" };

Perebor(a.coll);



Console.WriteLine("Hello, World!");


static void Perebor(IEnumerator enumerator)
{
    while (enumerator.MoveNext())
    {
        Console.WriteLine(enumerator.Current);
    }
}

// Создать метод для поиски и возвращения значения из массива любого типа