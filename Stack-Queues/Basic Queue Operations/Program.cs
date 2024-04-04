int[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

int elementsToDequeue = tokens[1];
int specialNumber = tokens[2];

for (int i = 0; i < elementsToDequeue; i++)
{
    queue.Dequeue();
}
if (queue.Contains(specialNumber))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Any())
    {
        Console.WriteLine(queue.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}