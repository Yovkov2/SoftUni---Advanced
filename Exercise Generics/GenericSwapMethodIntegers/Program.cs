public class StartUp
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        for (int i = 0; i < count; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        int[] swapes = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Swap(list, swapes[0], swapes[1]);
        foreach (var swape in list)
        {
            Console.WriteLine($"System.Int32: {swape}");
        }

    }
    static void Swap<T>(List<T> list, int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
}