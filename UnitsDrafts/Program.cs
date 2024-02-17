using UnitsDrafts;

Task task1 = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(600); 
        Console.WriteLine($"task: {i}");
    }
});

task1.Start();

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(500);
    Console.WriteLine($"main: {i}"); 
}
task1.Wait();
















