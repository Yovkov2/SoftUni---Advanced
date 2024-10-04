string people = Console.ReadLine();
Queue<string> queue = new Queue<string>();
while(people != "End")
{
    if(people == "Paid")
    {
        while(queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
    else
    {
        queue.Enqueue(people);
    }
    people = Console.ReadLine();
}
Console.WriteLine($"{queue.Count} people remaining.");