int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
Queue<int> queue = new();
foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        queue.Enqueue(number);
    }
}
while (queue.Count > 0)
{
    Console.Write(queue.Dequeue());
    if (queue.Count > 0) 
    {
        Console.Write(", ");
    }
}
