int littersPerKillometer = 1;

int count = int.Parse(Console.ReadLine());

Queue<int[]> queue = new();
for (int i = 0; i < count; i++)
{
    int[] allPumps = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    queue.Enqueue(allPumps);
}

int startIndex = 0;
while (true)
{
    bool isComplete = true;
    int totalLitters = 0;
    foreach (var pump in queue)
    {
        int litters = pump[0];
        int distance = pump[1];
        totalLitters += litters;
        if (totalLitters - distance * littersPerKillometer < 0)
        {
            startIndex++;
            int[] currentPump = queue.Dequeue();
            queue.Enqueue(currentPump);
            isComplete = false;
            break;
        }
        totalLitters -= distance * littersPerKillometer;
    }
    if (isComplete)
    {
        Console.WriteLine(startIndex);
        break;
    }
}