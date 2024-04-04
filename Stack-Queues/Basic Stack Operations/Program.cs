int[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int s = tokens[1];
int x = tokens[2];

Stack<int> stack = new Stack<int>(Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());
for(int i = 0; i < s; i++)
{
    stack.Pop();
}
if (stack.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    if (stack.Any())
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}