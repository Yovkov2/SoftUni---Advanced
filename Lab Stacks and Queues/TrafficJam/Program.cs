int greenPassed = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
int sum = 0;
Queue<string> queue = new Queue<string>();
while(command != "end")
{
    if(command == "green")
    {
        int carsToPass = Math.Min(greenPassed, queue.Count);

        for (int i = 0; i < carsToPass; i++)
        {
            string car = queue.Dequeue();
            Console.WriteLine($"{car} passed!");
            sum++;
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{sum} cars passed the crossroads.");