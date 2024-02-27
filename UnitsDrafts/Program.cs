int[] arr1 = new int[10];
int[] arr2 = new int[10];
int[] result = new int[10];
Task task1 = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(500);
        arr1[i] = new Random().Next(1, 10000);
        Console.WriteLine($"{arr1}");
    }
});
Task task2 = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(500);
        arr2[i] = new Random().Next(1, 10000);
        Console.WriteLine($"{arr2}");
    }
});
for (int i = 0; i < 10; i++)
{
    Thread.Sleep(500);
    result[i] = arr1[i]+arr2[i];
    Console.WriteLine($"{result}");
}
