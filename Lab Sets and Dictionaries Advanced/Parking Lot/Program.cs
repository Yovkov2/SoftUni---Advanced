string command = Console.ReadLine();
HashSet<string> carNumber = new();

while(command != "END")
{
    string[] tokens = command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
    string commandType = tokens[0];
    string number = tokens[1];
    if(commandType == "IN")
    {
            carNumber.Add(number);
    }
    else if(commandType == "OUT")
    {
       carNumber.Remove(number);
    }
    command = Console.ReadLine();
}
if (carNumber.Count() > 0)
{
    foreach(string token in carNumber)
    {
        Console.WriteLine(token);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}