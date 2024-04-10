int count = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> keyValuePairs = new();

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continents = tokens[0];
    string country = tokens[1];
    string cities = tokens[2];
    if (!keyValuePairs.ContainsKey(continents))
    {
        keyValuePairs.Add(continents, new Dictionary<string, List<string>>());
    }
    if (!keyValuePairs[continents].ContainsKey(country))
    {
        keyValuePairs[continents].Add(country, new List<string>());
    }
    keyValuePairs[continents][country].Add(cities);
}
foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key}:");
    foreach (var items in item.Value)
    {
        Console.WriteLine($" {items.Key} -> {string.Join(", ", items.Value)}");
    }
}