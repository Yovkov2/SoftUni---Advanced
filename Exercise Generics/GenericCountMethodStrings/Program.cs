public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> elements = new List<Box<string>>();
        for (int i = 0; i < n; i++)
        {
            elements.Add(new Box<string>(Console.ReadLine()));
        }

        Box<string> value = new Box<string>(Console.ReadLine());


        int result = CountGreaterElements(elements, value);

        Console.WriteLine(result);
    }
    public static int CountGreaterElements<T>(List<Box<T>> list, Box<T> element) where T : IComparable<T>
    {
        int count = 0;
        foreach (var item in list)
        {
            if (item.IsGreaterThan(element))
            {
                count++;
            }
        }
        return count;
    }
}
