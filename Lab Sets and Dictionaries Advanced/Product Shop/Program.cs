string command = Console.ReadLine();
SortedDictionary<string, Dictionary<string, decimal>> keyValuePairs = new();
while (command != "Revision")
{
    string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shop = tokens[0];
    string product = tokens[1];
    decimal price = decimal.Parse(tokens[2]);
    if (!keyValuePairs.ContainsKey(shop))
    {
        keyValuePairs.Add(shop, new Dictionary<string, decimal>());
    }
    if (!keyValuePairs.ContainsKey(product))
    {
        keyValuePairs[shop].Add(product, 0);
    }
    keyValuePairs[shop][product] = price;
    command = Console.ReadLine();
}
foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key}->");
    foreach (var items in item.Value)
    {
        Console.WriteLine($"Product: {items.Key}, Price: {items.Value:f1}");
    }
}