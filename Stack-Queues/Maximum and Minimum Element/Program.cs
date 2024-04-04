int count = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();

for (int i = 0; i < count; i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    int command = tokens[0];
    if(command == 1)
    {
        int value = tokens[1];
        stack.Push(value);
    }
    else if(command == 2)
    {
         stack.Pop();
    }
    else if(command == 3)
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Max());
        }
    }
    else
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Min());
        }
    }
}
Console.WriteLine(string.Join(", ", stack));