public class Box<T> where T : IComparable<T>
{
    public T Data { get; }
    public Box(T data)
    {
        Data = data;
    }

    public bool IsGreaterThan(Box<T> box)
    {
        return Data.CompareTo(box.Data) > 0;
    }
}