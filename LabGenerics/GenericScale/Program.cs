public class StartUp
{
    static void Main(string[] args)
    {
        EqualityScale<int> intScale = new EqualityScale<int>(5, 5);
        bool intsAreEqual = intScale.AreEqual();
        Console.WriteLine("Integers are equal: " + intsAreEqual);

        EqualityScale<string> stringScale = new EqualityScale<string>("apple", "banana");
        bool stringsAreEqual = stringScale.AreEqual();
        Console.WriteLine("Strings are equal: " + stringsAreEqual);
    }
}
public class EqualityScale<T>
{
    private T left;
    private T right;

    public EqualityScale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }
    public bool AreEqual()
    {
        return(left.Equals(right));
    }
}
