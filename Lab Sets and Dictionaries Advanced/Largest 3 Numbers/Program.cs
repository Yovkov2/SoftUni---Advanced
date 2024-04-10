int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] sorted = numbers.OrderByDescending(n=> n).ToArray();
for (int i = 0; i < sorted.Length; i++)
{
    if(i < 3)
    {
        Console.Write(sorted[i] + " ");
    }
    else
    {
        break;
    }
}