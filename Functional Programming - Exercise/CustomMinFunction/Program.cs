int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(Parse)
    .ToArray();

Console.WriteLine(numbers.Min());

static int Parse(string input)
{
    return int.Parse(input);
}