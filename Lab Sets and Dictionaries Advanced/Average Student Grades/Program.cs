int count = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = tokens[0];
    decimal grade = decimal.Parse(tokens[1]);
    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<decimal>());
    }
    students[name].Add(grade);
}
foreach (var item in students)
{
    Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value)} (avg: {item.Value.Average()})");
}