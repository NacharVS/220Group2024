int[,] arr1 = new int[5, 3];
int[,] arr2 = new int[5, 3];
int[,] arrRes = new int[5, 3];
Task task = new Task(() =>
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)

        {
            arr1[i, j] = new Random().Next(1, 10);
        }
    }
});
Task task2 = new Task(() =>
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            arr2[i, j] = new Random().Next(1, 10);
        }
    }
});
task.Start();
task2.Start();
Thread.Sleep(100);
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        arrRes[i, j] = arr1[i, j] + arr2[i, j];
    }
    Console.WriteLine($"Result {i + 1}: [{arrRes[i, 0]}] [{arrRes[i, 1]}] [{arrRes[i, 2]}]");
}