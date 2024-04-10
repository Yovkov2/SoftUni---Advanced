double[] value = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

Dictionary<double, int> result = new Dictionary<double, int>();

foreach (var item in value)
{
    if (!result.ContainsKey(item))
    {
        result.Add(item, 0);
    }
    result[item]++;
}
foreach (var item in result)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}