Predicate<string> filter = x => x[0] == char.ToUpper(x[0]) && char.IsLetter(x[0]);

string[] text = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Where(x=> filter(x))
    .ToArray();

Print(text);

static void Print(string[] text)
{
    foreach (var changedText in text)
    {
        Console.WriteLine(changedText);
    }
}