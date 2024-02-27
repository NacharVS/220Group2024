int[,] arr1 = new int[5, 5];
int[,] arr2 = new int[5, 5];
int[,] result = new int[5, 5];
int[] res2 = new int[5];
Task task1 = new Task(() =>
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            arr1[i, j] = new Random().Next(1, 20);
        }
    }
});
Task task2 = new Task(() =>
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            arr2[i, j] = new Random().Next(1, 20);
        }
    }
});
task1.Start();
task2.Start();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++)
    {
        result[i, j] = arr1[i, j] + arr2[i, j];
        Console.Write($"{result[i, j]} ");
    }
}
Console.WriteLine();
for (int i = 0;i < 5; i++) 
{ 
for (int j = 0;j < 5; j++)
    {
        res2[i] += result[j, i];
    }
    Console.Write($"{res2[i]} ");
}

