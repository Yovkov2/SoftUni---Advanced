Stack<int> stack = new Stack<int>(Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

int racks = int.Parse(Console.ReadLine());
int sumOfRacks = 1;
int currentRack = racks;
while(stack.Count > 0)
{
    currentRack -= stack.Peek();
    if(currentRack < 0)
    {
        currentRack = racks;
        sumOfRacks++;
        continue;
    }
    stack.Pop();
}
Console.WriteLine(sumOfRacks);