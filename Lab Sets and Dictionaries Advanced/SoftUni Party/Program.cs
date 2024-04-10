HashSet<string> set = new();
while (true)
{
    string command = Console.ReadLine();
    if (command == "PARTY")
    {
        break;
    }
    set.Add(command);
}
while (true)
{
    string command = Console.ReadLine();
    if (command == "END")
    {
        break;
    }
    if (set.Contains(command))
    {
        set.Remove(command);
    }
}
Console.WriteLine(set.Count);
foreach (string command in set)
{
    char[] ch = command.ToCharArray();
    if (char.IsDigit(ch[0]))
    {
        Console.WriteLine(command);
    }
}
foreach (string command in set)
{
    char[] chars = command.ToCharArray();
    if (char.IsLetter(chars[0]))
    {
        Console.WriteLine(command);
    }
}