public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<double>> elements = new List<Box<double>>();
        for (int i = 0; i < n; i++)
        {
            elements.Add(new Box<double>(double.Parse(Console.ReadLine())));
        }

        Box<double> value = new Box<double>(double.Parse(Console.ReadLine()));


        double result = CountGreaterElements(elements, value);

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
