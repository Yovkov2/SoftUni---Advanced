public class StartUp
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        List<string> boxes = new List<string>();

        for (int i = 0; i < count; i++)
        {
            boxes.Add(Console.ReadLine());
        }

        int[] swapped = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Swap(boxes, swapped[0], swapped[1]);

        foreach (var i in boxes)
        {
            Console.WriteLine($"System.String: {i}");
        }
    }
    static void Swap<T>(List<T> list, int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
}
       