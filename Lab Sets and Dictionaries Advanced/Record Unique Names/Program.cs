int count = int.Parse(Console.ReadLine());
HashSet<string> list = new HashSet<string>();
for (int i = 0; i < count; i++)
{
    string name = Console.ReadLine();
    list.Add(name);
}
foreach (string name in list)
{
    Console.WriteLine(name);
}