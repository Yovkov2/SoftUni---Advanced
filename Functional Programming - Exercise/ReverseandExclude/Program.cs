int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

List<int> result = new List<int>();
int number = int.Parse(Console.ReadLine());
for (int i = 0; i < numbers.Length; i++)
{
    methodtoAdd(numbers, result, number, i);
}
result.Reverse();
Console.WriteLine(string.Join(" ", result));
static void methodtoAdd(int[] numbers, List<int> result, int number, int i)
{
    if (numbers[i] % number != 0)
    {
        result.Add(numbers[i]);
    }
}