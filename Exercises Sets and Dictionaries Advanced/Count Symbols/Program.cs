string text = Console.ReadLine();
SortedDictionary<char,int> occurrences = new SortedDictionary<char,int>();

foreach(char ch in text)
{
    if (!occurrences.ContainsKey(ch))
    {
        occurrences.Add(ch,0);
    }
    occurrences[ch]++;
}
foreach(var ch in occurrences)
{
    Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
}