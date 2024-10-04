string[] children = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>(children);

while(queue.Count > 1)
{
    for(int i = 0; i < n-1; i++)
    {
        string currentChild = queue.Dequeue();
        queue.Enqueue(currentChild);
    }

    string removedChildren = queue.Dequeue();
    Console.WriteLine($"Removed {removedChildren}");
}
Console.WriteLine($"Last is {queue.Dequeue()}");