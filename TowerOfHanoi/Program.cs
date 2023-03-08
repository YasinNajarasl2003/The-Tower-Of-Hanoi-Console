using System.Diagnostics;
using TowerOfHanoi;
bool flag = true;
while(flag)
{
    int diskCount = 0;
    Console.Write("how many disk do you want to calculate (Zero to exit):");
    try
    {
        diskCount = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        break;
    }
    if(diskCount == 0)
    {
        flag = false;
        break;
    }

    Stopwatch stopwatch = Stopwatch.StartNew();
    Calculate.Towers(diskCount, 1, 3, 2);
    stopwatch.Stop();
    Console.WriteLine(stopwatch.ElapsedMilliseconds);
}