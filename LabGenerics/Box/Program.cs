using System.Xml.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        Box<int> box = new();
        box.Add(1);
        box.Add(2);
        box.Add(3);

        Console.WriteLine(box.Remove());
        box.Add(4);
        box.Add(5);
        Console.WriteLine(box.Remove());
    }
}
public class Box<T>
{
    private List<T> list;
    public Box()
    {
        list = new List<T>();
    }
    public void Add(T item)
    {
        list.Add(item);
    }
    public T Remove()
    {
        T removedElement = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return removedElement;
    }
    public int Count
    {
        get { return list.Count; }
    }
}