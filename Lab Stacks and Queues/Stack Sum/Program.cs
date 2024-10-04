int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
Stack<int> stack = new Stack<int>(numbers);
string input;
while ((input = Console.ReadLine().ToLower()) != "end")
{
    string[] commands = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    string type = commands[0];
    if(type == "add")
    {
        int number = int.Parse(commands[1]);
        int numberSecond = int.Parse(commands[2]);

        stack.Push(number);
        stack.Push(numberSecond);
         
    }
    else if(type == "remove")
    {
        int numberToRemove = int.Parse(commands[1]);
        if (numberToRemove <= stack.Count)
        {
            for (int i = 0; i < numberToRemove; i++)
            {
                stack.Pop();
            }
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");