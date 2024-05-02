string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string> printName = (string name) =>
{
    Console.WriteLine(name);
};
foreach (string name in names)
{
    printName(name);
}