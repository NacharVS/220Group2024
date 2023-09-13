int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = numberOne % 10;
numberOne = numberOne / 10;
int numberThree = numberOne % 10;
numberOne = numberOne / 10;
if (numberOne > numberTwo)
{
    if (numberOne < numberThree)
    {
        Console.WriteLine(numberOne);
    }
}
if (numberTwo > numberOne)
{
    if (numberTwo < numberThree)
    {
        Console.WriteLine(numberTwo);
    }
}
if (numberOne > numberThree)
{
    if (numberOne < numberTwo)
    {
        Console.WriteLine(numberOne);
    }
}
if (numberThree > numberOne)
{
    if(numberThree < numberTwo)
    {
        Console.WriteLine(numberThree);
    }
}
if (numberTwo > numberThree)
{
    if (numberTwo < numberOne)
    {
       Console.WriteLine(numberTwo);
    }
}
if (numberThree > numberTwo)
{
    if (numberThree < numberOne)
    {
        Console.WriteLine(numberThree);
    }
}
if (numberOne == numberTwo)
{
    Console.WriteLine("Нет среднего числа");
}
if (numberOne == numberThree)
{
    Console.WriteLine("Нет среднего числа");
}
if (numberTwo == numberThree)
{
    Console.WriteLine("Нет среднего числа");
}