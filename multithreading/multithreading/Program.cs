int[,] arr1 = new int[10,10];
int[,] arr2 = new int[10, 10];
int[,] Sumarrays = new int[10, 10];
Random rand = new Random();
Task task1 = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            arr1[i, j] = rand.Next(1, 10);
        }
    }
});

Task task2 = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            arr2[i, j] = rand.Next(1, 10);
        }
    }
});
task1.Start();
task2.Start();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 10; j++)
    {
        Sumarrays[i, j] = arr1[i,j] + arr2[i, j];
        Console.Write($" {Sumarrays[i, j]}");
    }
}