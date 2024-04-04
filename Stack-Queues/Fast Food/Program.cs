int quantity = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>(Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());
Console.WriteLine(queue.Max());
while (queue.Any())
{
    int currentOrder = queue.Peek();
    if(quantity >= currentOrder)
    {
        queue.Dequeue();
        quantity-=currentOrder;
    }
    else
    {
        break;
    }
}
if (queue.Any())
{
    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
}
else
{
    Console.WriteLine("Orders complete");
}