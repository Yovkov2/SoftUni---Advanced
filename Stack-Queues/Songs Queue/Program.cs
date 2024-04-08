Queue<string> songs = new(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries));
while (songs.Any())
{
  string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

    if (commands[0] == "Play")
    {
        if (songs.Any())
        {
            songs.Dequeue();
        }
    }
    else if (commands[0] == "Add")
    {
        string song = string.Join(" ", commands.Skip(1));
        if (!songs.Contains(song))
        {
            songs.Enqueue(song);
        }
        else
        {
            Console.WriteLine($"{song} is already contained!");
        }
    }
    else if (commands[0] == "Show")
    {
        if (songs.Any())
        {
            Console.WriteLine($"{string.Join(", ", songs)}");
        }
    }
}
Console.WriteLine("No more songs!");