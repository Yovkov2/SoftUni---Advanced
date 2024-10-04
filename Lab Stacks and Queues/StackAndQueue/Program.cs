string input = Console.ReadLine();

Stack<char> chars = new Stack<char>();

foreach (var item in input)
{
    chars.Push(item);
}
while (chars.Count > 0)
{
    Console.Write(chars.Pop());
}