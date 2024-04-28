int[] numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(Parse)
    .ToArray();

Print(numbers);
static int Parse(string x)
{
    return int.Parse(x);
}

static void Print(int[] numbers)
{
    Console.WriteLine(numbers.Count());
    Console.WriteLine(numbers.Sum());
}