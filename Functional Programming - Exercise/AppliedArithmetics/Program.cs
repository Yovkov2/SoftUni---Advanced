int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = Console.ReadLine();

while(command != "end")
{
    mathematical(numbers, command);
    command = Console.ReadLine();
}

static void mathematical(int[] numbers, string command)
{
    if (command == "add")
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] += 1;
        }
    }
    else if (command == "multiply")
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 2;
        }
    }
    else if (command == "subtract")
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] -= 1;
        }
    }
    else if (command == "print")
    {
        foreach (int i in numbers)
        {
            Console.Write(i + " ");
        }
    }
}