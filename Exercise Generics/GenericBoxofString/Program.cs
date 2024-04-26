public class StartUp
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string text = Console.ReadLine();
            Box<string> box = new(text);
            Console.WriteLine(box.ToString());
        }
    }
}
