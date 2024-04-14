int nCount = int.Parse(Console.ReadLine());
HashSet<string> list = new HashSet<string>();
for (int i = 0; i < nCount; i++)
{
    string names = Console.ReadLine();
    list.Add(names);
}
foreach (string name in list)
{
    Console.WriteLine(name);
}