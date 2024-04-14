int count = int.Parse(Console.ReadLine());
Dictionary<int, int> map = new Dictionary<int, int>();

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!map.ContainsKey(number))
    {
        map.Add(number, 0);
    }
    map[number] += 1;
}

foreach(var number in map)
{
    if(number.Value % 2 == 0)
    {
        Console.WriteLine(number.Key);
    }
}