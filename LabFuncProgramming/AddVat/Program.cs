double[] numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(Double)
    .Select(x=> x*1.2)
    .ToArray();

foreach (var number in numbers)
{
    Console.WriteLine($"{number:f2}");
}

static double Double(string s)
{
    return double.Parse(s);
}