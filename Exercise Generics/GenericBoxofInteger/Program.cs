public class StartUp
{
    static void Main(string[] args)
    {
       int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            Box<int> box = new(numbers);
            Console.WriteLine(box.ToString());
        }
    }
}
