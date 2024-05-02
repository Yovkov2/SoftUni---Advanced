int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
string command = Console.ReadLine();
for (int i = numbers[0]; i <= numbers[1]; i++)
{
    if (command == "odd")
    {
        if (i % 2 != 0)
        {
            Console.Write(i + " ");
        }
    }
    else if (command == "even")
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}