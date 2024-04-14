int count = int.Parse(Console.ReadLine());
HashSet<string> list = new HashSet<string>();
for (int i = 0; i < count; i++)
{
    string[] chemicalElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
    foreach (string element in chemicalElements)
    {
        list.Add(element);
    }
}
foreach (string element in list.OrderBy(x=>x))
{
    Console.Write($"{element} ");
}