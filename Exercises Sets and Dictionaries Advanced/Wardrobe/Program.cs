int count = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> keyValuePairs = new();

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
    string color = tokens[0];

    if (!keyValuePairs.ContainsKey(color))
    {
        keyValuePairs.Add(color, new Dictionary<string, int>());
    }
    for (int j = 1; j < tokens.Length; j++)
    {
        string dress = tokens[j];
        if (!keyValuePairs[color].ContainsKey(dress))
        {
            keyValuePairs[color].Add(dress, 0);
        }
        keyValuePairs[color][dress]++;
    }
}

string[] foundDress = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key} clothes:");
    foreach(var item2 in item.Value)
    {
        string result = $"* {item2.Key} - {item2.Value}";
        if (item.Key == foundDress[0] && item2.Key == foundDress[1])
        {
            result += $" (found!)";
        }
        Console.WriteLine(result);
    }
}