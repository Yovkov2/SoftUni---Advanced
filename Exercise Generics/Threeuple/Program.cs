public class StartUp
{
    static void Main(string[] args)
    {
        string[] info = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Tuple<string, string,string> infoPeople = new(info[0], info[1], info[2]);
        Console.WriteLine(infoPeople.ToString());

        string[] beerInfo = Console.ReadLine()
     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Tuple<string, int, string> beer = new Tuple<string, int, string>(beerInfo[0], int.Parse(beerInfo[1]), beerInfo[2]);
        Console.WriteLine(beer.ToString());

        string[] line = Console.ReadLine()
   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Tuple<string, double,string> lines = new(info[0], double.Parse(info[1]), info[2]);
        Console.WriteLine(lines.ToString());
    }
}
