public class StartUp
{
    static void Main(string[] args)
    {
        CustomStack stack = new CustomStack();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Count of items in the stack: " + stack.Count);
        Console.WriteLine("Top item of the stack: " + stack.Peek());

        Console.WriteLine("Popping items from the stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

    }
}
public class CustomStack
{
    private const int InitialCapacity = 4;
    private int[] items;
    private int count;

    public CustomStack()
    {
        items = new int[InitialCapacity];
        count = 0;
    }

    public int Count => count;

    public void Push(int item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count] = item;
        count++;
    }

    public int Pop()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        int item = items[count - 1];
        count--;
        return item;
    }

    public int Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        return items[count - 1];
    }
}