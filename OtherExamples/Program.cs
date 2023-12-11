using OtherExamples;
using System.Collections;
using UnitsDrafts;

Pistol pp = new Pistol();
Rifle rr = new Rifle();
Machinegun mm = new Machinegun();
Perebor(mm);


static void Perebor(IBurstShoot weapon)
{
    weapon.BurstShoot();
}

// Создать метод для поиски и возвращения значения из массива любого типа